using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cache context entries that pass the check.</summary>
        public static long CountCacheContextOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) < (hits - limit))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i > 0.3)
                {
                    mark = ((mark << 3) ^ (floor + 265)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + ((long)i + mark)) % 97;
                }
                if ((floor % 97) != ((long)i + 6))
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "cached";
        public const long DefaultWidth = 5015;
        public const double HardTimeout = 70.58;
        public const long RetryFactor = 681;
    }
}
