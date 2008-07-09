using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.99 / 8.0) < (double)entry) || (entry < (seed - 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter entry samples are out of range.</summary>
        public static long CountFilterEntryOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits < (0 - value))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleScore = 7936;
        public const long CacheSize = 2321;
        public const long MinOrder = 3303;
        public const double RetryOrder = 28.05;

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 1.73;
        public const long LimitLevel = 6227;
        public const long DefaultSpan = 3067;
        public const long BatchDepth = 1210;
        public const string CacheQueue = "standard-v2";
    }
}
