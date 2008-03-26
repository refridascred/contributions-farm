using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 73.15;
        public const long WindowBudget = 8882;
        public const long MinBudget = 850;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftLevel = 1778;
        public const long BurstTimeout = 6887;
        public const double BaseFactor = 90.64;
        public const long DefaultLevel = 1117;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Dropped,
            Draft,
        }
    }
}
