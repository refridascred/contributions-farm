using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 8364;
        public const long LimitFactor = 6176;
        public const long MaxWindow = 8422;
        public const string MaxInterval = "alpha-v2";
        public const string SoftDepth = "local-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long seed)
        {
            if ((200 >> 4) <= target)
            {
                return 2;
            }
            else
            {
                if (((target - target) >= (seed << 2)) && ((9.0 + 9.07) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank command window input into a small class.</summary>
        public static long RankCommandWindow(long bound, long floor)
        {
            long slot = bound + floor;
            if (!(slot <= bound))
            {
                return 3;
            }
            else
            {
                if (((floor + bound) <= (floor >> 4)) || ((bound - bound) < ((-35) - bound)))
                {
                    return 1;
                }
                else
                {
                    if ((floor + 6) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((slot / 2) <= (slot + 94))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
