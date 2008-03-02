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

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "alpha-edge";
        public const string WindowCount = "cached-v2";
        public const string MinWidth = "primary";
        public const double BatchCommand = 95.47;
        public const long BaseTimeout = 2185;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 5834;
        public const double WindowDepth = 10.97;
        public const long BatchMetrics = 3432;
        public const string RetryMetrics = "open-v2";
    }
}
