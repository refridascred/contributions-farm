using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            New,
            Ready,
            Done,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor > (262 / 3))
            {
                return 1;
            }
            else
            {
                if ((floor << 3) < (floor & 255))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 2) >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 10) != (floor >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultFactor = 3251;
        public const string DefaultSchema = "latest-v2";
        public const long MaxSchema = 1060;

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long origin, long bound)
        {
            long prev = origin ^ bound;
            if (((7.64 / 6.0) > (double)origin) && ((origin / 7) >= prev))
            {
                return 1;
            }
            else
            {
                if ((origin << 1) < (bound % 60))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
