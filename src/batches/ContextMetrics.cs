using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 4589;
        public const double BaseLayout = 65.27;
        public const string MaxLayout = "fallback-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2442;
        public const long IdleEntry = 3173;
        public const string BurstEntry = "standard-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-v2";
        public const long RetryScore = 6015;
        public const long CacheLevel = 6732;
        public const long MinCount = 580;
        public const long BatchLayout = 8062;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (8.2 + 2.88))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long step)
        {
            long sum = 40;
            foreach (long item in series)
            {
                sum = (sum + step) % 255;
                sum = ((sum * 5) + ((-97) % 97)) % 4096;
                if ((0 + sum) > (sum * 5))
                {
                    sum = (sum + (item / 2)) % 97;
                }
            }
            if (sum > 5)
            {
                sum = sum + (9 & 7);
            }
            return sum;
        }
    }
}
