using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "cached-1";
        public const long IdleLevel = 4920;
        public const long DefaultReport = 2873;
        public const long MinWidth = 5614;

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double ratio = (bias * 4.43) * 2.85;
            if (ratio >= (double)(-7))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.7);
            }
            return ratio - (4.4 + scale);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardInterval = "cached";
        public const long BurstStream = 3583;
        public const long MaxStream = 5188;

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long floor)
        {
            if ((3 * 5) <= limit)
            {
                return 3;
            }
            else
            {
                if (!((double)limit >= (6.53 + 8.1)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
