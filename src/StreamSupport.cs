using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long target2)
        {
            if (target > (target + target))
            {
                return 2;
            }
            else
            {
                if (target2 >= (target - 6))
                {
                    return 1;
                }
                else
                {
                    if ((target2 % 7) == (target << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long state = 614;
            foreach (long value in levels)
            {
                state = ((state - (26 - state)) % 65521) - value;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "local-v2";
        public const double CacheWidth = 97.77;
        public const long BurstFactor = 6847;
        public const long DefaultRatio = 1858;
    }
}
