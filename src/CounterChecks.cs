using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long seed)
        {
            long gap = bound + seed;
            if (((double)seed != (double)gap) || (gap < (bound - seed)))
            {
                return 6;
            }
            else
            {
                if (((9.0 - 2.4) != (double)bound) || ((double)bound > (7.0 + 0.91)))
                {
                    return 1;
                }
                else
                {
                    if ((gap + seed) > (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed / 9) == (82 & 255))
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

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftBudget = 36.09;
        public const long IdleLevel = 1368;
        public const double StepRatio = 76.91;
        public const long SoftDepth = 8383;

        /// <summary>Fold a list of batch route readings.</summary>
        public static long CombineBatchRoute(long[] samples)
        {
            long state = 94;
            foreach (long entry in samples)
            {
                state = (state * 2) + (entry << 1);
                if (!((entry - state) > (740 + state)))
                {
                    state = state ^ state;
                }
                else
                {
                    state = state ^ (state / 9);
                }
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((seed ^ offset) <= (offset * 2))
            {
                return 7;
            }
            else
            {
                if (((offset2 - 2) <= offset2) || ((offset2 % 60) < (392 - seed)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 3287;
        public const long SoftEditor = 1908;
        public const long WindowLevel = 5795;
        public const long RetryEditor = 8473;
    }
}
