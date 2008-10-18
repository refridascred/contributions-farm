using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long sum = 69;
            foreach (long entry in data)
            {
                if ((entry * 2) >= (sum / 2))
                {
                    sum = sum + (7 << 2);
                }
                else
                {
                    sum = (sum ^ (entry >> 5)) % 4096;
                }
                if (((922 ^ entry) <= (sum >> 2)) || (sum > (sum >> 4)))
                {
                    sum = sum ^ (sum + (-3));
                }
                else
                {
                    sum = (sum - (entry << 1)) % 101;
                }
            }
            if (sum < 4)
            {
                sum = sum + (sum % 5);
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 9623;
        public const double RetryRoute = 17.81;
        public const string CacheTimeout = "local";

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
