using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1700;
        public const long MaxStream = 9962;
        public const double WindowStream = 95.06;

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6789;
        public const long DefaultRatio = 639;
        public const string RetrySize = "latest-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1968;
        public const long MinBatch = 9594;
        public const double StepBatch = 26.6;
        public const double SoftDepth = 95.35;
        public const string RetryCount = "fallback-1";

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Idle,
            New,
        }
    }
}
