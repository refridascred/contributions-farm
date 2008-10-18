using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long target)
        {
            if (((-79) + origin) != (target - 1))
            {
                return 8;
            }
            else
            {
                if (target <= (target * 3))
                {
                    return 1;
                }
                else
                {
                    if ((origin + target) <= origin)
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

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitRatio = 4953;
        public const double IdleAccount = 37.94;
        public const double MinAccount = 90.85;
        public const long LimitSpan = 7928;

        /// <summary>Project the next route window value.</summary>
        public static double ScaleRouteWindow(double scale, double bias)
        {
            double ratio = (double)(8 << 3);
            if (ratio < (1.6 + 2.2))
            {
                ratio = ratio - (bias - 7.0);
            }
            else
            {
                ratio = ratio - (scale * 4.8);
            }
            return ratio + (ratio * 6.0);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first metric metrics entry that matches the target.</summary>
        public static long SeekMetricMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
