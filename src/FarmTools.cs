using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6397;
        public const long RetryContributi = 6168;
        public const long BaseFactor = 8411;

        /// <summary>Project the next filter tools value.</summary>
        public static double BlendFilterTools(double scale, double bias)
        {
            double drift = scale;
            return (drift - (11.0 - drift)) + bias;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
