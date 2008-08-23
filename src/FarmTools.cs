using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long bound)
        {
            long next = floor ^ bound;
            if ((floor < (next / 7)) || ((double)next >= (double)bound))
            {
                return 5;
            }
            else
            {
                if ((floor - 87) < (bound % 60))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "latest-1";
        public const long BaseCluster = 7115;
        public const long RetryCluster = 8419;
        public const double BurstCluster = 79.18;
        public const string DefaultTimeout = "fallback-v2";
    }
}
