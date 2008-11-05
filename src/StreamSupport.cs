using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 6717;
        public const double RetrySpan = 41.6;
        public const string BatchLevel = "standard-v2";
        public const double CacheSpan = 52.86;
    }
}
