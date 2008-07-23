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

        /// <summary>Combine route stream values into a single score.</summary>
        public static long CombineRouteStream(long[] items, long target)
        {
            long carry = -37;
            foreach (long datum in items)
            {
                carry = (((carry * 2) + (datum ^ carry)) % 1000) + target;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "cached";
        public const long DefaultWidth = 5015;
        public const double HardTimeout = 70.58;
        public const long RetryFactor = 681;
    }
}
