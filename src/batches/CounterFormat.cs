using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long floor)
        {
            if ((floor + floor) == (target * 2))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (7.98 + 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double span)
        {
            double ratio = (double)(625 + 538);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)(long)i) - scale;
            }
            return ratio - span;
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
