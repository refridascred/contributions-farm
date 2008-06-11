using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 6684;
        public const long RetryMetrics = 3675;
        public const double CacheInterval = 8.63;
        public const long BurstDepth = 4661;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            New,
            Idle,
            Done,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Locked,
            Failed,
            Stale,
        }
    }
}
