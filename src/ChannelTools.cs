using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "latest-v2";
        public const double IdleRatio = 38.28;
        public const long MinContext = 2887;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5834;
        public const double WindowDepth = 10.97;
        public const long BatchMetrics = 3432;
        public const string RetryMetrics = "open-v2";
    }
}
