using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples, long origin)
        {
            long mark = 641;
            foreach (long datum in samples)
            {
                mark = ((mark + mark) - datum) - origin;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 1298;
        public const string CacheRatio = "latest-1";
        public const string DefaultTimeout = "staging-edge";
        public const string HardDepth = "open";

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSize = 5376;
        public const double CacheToken = 77.38;
        public const string WindowToken = "staging";
        public const long WindowInterval = 1736;

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double bias)
        {
            double mean = weight;
            if (mean <= bias)
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
