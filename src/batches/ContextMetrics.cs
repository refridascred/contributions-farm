using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 14.52;
        public const double MaxWidth = 23.01;
        public const long DefaultBudget = 6245;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            if ((origin & 31) == (20 + origin))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) != (origin - origin))
                {
                    return 7;
                }
                else
                {
                    if (seed < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long bound)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if (bound <= entry)
                {
                    state = ((state * 2) + (state - entry)) % 97;
                    state = (state + (299 - bound)) % 101;
                }
                state = state - (7 / 5);
            }
            if (state < 5)
            {
                state = ((state * 5) + (state % 10)) % 4096;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "stable-v2";
        public const long MinWidth = 9580;
        public const double StepScore = 49.78;
        public const string IdleCache = "alpha-edge";
        public const double MaxCache = 51.28;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
