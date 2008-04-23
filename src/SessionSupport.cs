using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long floor)
        {
            if ((seed + seed) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((6.42 < (double)seed) || ((floor - 93) == (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < (3.3 + 19.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long bound)
        {
            if ((floor ^ bound) <= bound)
            {
                return 1;
            }
            else
            {
                if (bound >= (bound + floor))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Pending,
            Done,
            Stale,
        }
    }
}
