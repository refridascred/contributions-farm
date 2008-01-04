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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long total = 70;
            foreach (long value in items)
            {
                if ((2.4 - 17.0) <= (double)value)
                {
                    total = (total * 2) + ((-92) * 5);
                }
                else
                {
                    total = ((total * 3) + value) % 65521;
                }
            }
            if (total > 1)
            {
                total = ((total * 5) + (total * 3)) % 101;
            }
            return total % 97;
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long floor, long origin)
        {
            if ((floor - origin) > (floor >> 5))
            {
                return 1;
            }
            else
            {
                if ((floor + origin) <= (origin + floor))
                {
                    return 4;
                }
                else
                {
                    if (origin >= (floor - 21))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 4.0) < (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

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
