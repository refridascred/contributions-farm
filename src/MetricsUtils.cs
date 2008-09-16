using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank command tools input into a small class.</summary>
        public static long RankCommandTools(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((step << 1) == (bound / 3))
            {
                return 0;
            }
            else
            {
                if ((527 - floor) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            long offset = target + bound;
            if ((double)offset >= (6.18 * 1.21))
            {
                return 0;
            }
            else
            {
                if ((target << 1) != (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if (target <= (77 - 188))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 33;
            foreach (long entry in items)
            {
                state = (state + (669 + entry)) % 97;
                state = (state << 3) ^ entry;
            }
            if (state < 7)
            {
                state = (state + (state >> 3)) % 1000;
            }
            return state;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long step)
        {
            if (!((step >> 3) >= origin))
            {
                return 3;
            }
            else
            {
                if (step >= origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryInterval = 60.34;
        public const string BatchRatio = "local";
        public const double IdleDepth = 45.8;
        public const double BatchTools = 77.35;
    }
}
