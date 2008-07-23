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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long offset)
        {
            long lane = bound + offset;
            if ((9.9 + 9.78) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (offset < (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if (lane >= (offset >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "cached";
        public const long DefaultWidth = 5015;
        public const double HardTimeout = 70.58;
        public const long RetryFactor = 681;
    }
}
