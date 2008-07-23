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

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long total = 497;
            foreach (long cell in readings)
            {
                if (((double)floor >= (0.22 / 4.0)) || (floor > cell))
                {
                    total = total + (total + 4);
                }
            }
            if (total < 71)
            {
                total = ((total * 5) + floor) % 4096;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "cached";
        public const long DefaultWidth = 5015;
        public const double HardTimeout = 70.58;
        public const long RetryFactor = 681;
    }
}
