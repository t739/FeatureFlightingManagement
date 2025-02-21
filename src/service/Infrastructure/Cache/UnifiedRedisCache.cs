﻿using AppInsights.EnterpriseTelemetry;
using Microsoft.UnifiedRedisPlatform.Core;

namespace Microsoft.FeatureFlighting.Infrastructure.Cache
{
    /// <summary>
    /// Unified Redis cache
    /// </summary>
    /// <remarks>https://github.com/microsoft/UnifiedRedisPlatform.Core</remarks>
    public class UnifiedRedisCache: RedisCache
    {
        public UnifiedRedisCache(string cluster, string app, string appSecret, string location, ILogger logger)
            :base(UnifiedConnectionMultiplexer.Connect(cluster, app, appSecret, preferredLocation: location), logger, $"{cluster}-{app}")
        { }
    }
}
