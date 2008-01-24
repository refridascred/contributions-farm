using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long target, long bound)
        {
            long prev = target - bound;
            if (((target - 2) > (prev << 3)) || ((target + bound) < prev))
            {
                return 7;
            }
            else
            {
                if ((3.92 * 6.89) == (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((13 << 3) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
