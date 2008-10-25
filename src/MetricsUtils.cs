using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const long CacheInterval = 2943;
        public const long MinMetric = 4344;
        public const long HardSize = 1459;
        public const double IdleTimeout = 9.85;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 3714;
        public const long CacheBatch = 662;
        public const long RetryLevel = 9653;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double drift = (double)(641 - 62);
            if (drift <= drift)
            {
                drift = (drift + 6.4) + gain;
            }
            return drift + (offset - 8.95);
        }
    }
}
