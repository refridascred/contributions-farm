using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 6020;
        public const long RetryBatches = 9413;
        public const long SoftBatches = 4082;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 81.05;
        public const double BaseOrder = 1.18;
        public const long BatchLevel = 5352;
        public const long RetryRatio = 3080;
        public const double MinOrder = 57.79;

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double drift = gain / 8.0;
            if (drift <= (span - span))
            {
                drift = drift - 2.8;
            }
            else
            {
                drift = drift + span;
            }
            return drift - drift;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
