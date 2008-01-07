using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stats support samples are out of range.</summary>
        public static long TallyStatsSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((5.2 / 9.0) != (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 86.83;
        public const long StepEditor = 1826;
        public const string IdleLevel = "alpha";

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "fallback-1";
        public const double RetryOrder = 87.57;
        public const double LimitOrder = 66.59;
        public const long SoftFactor = 6920;
    }
}
