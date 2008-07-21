using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheInterval = "local-1";
        public const double LimitLevel = 0.13;
        public const double HardSpan = 55.54;
        public const double DefaultSupport = 75.84;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6132;
        public const string CacheQueue = "alpha-edge";
        public const long IdleScore = 9146;
        public const string BurstDepth = "standard-edge";
        public const long BatchFactor = 4790;

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double bias = (rate + 7.61) / 8.0;
            if (bias > bias)
            {
                bias = (bias - rate) - floor;
            }
            return bias + rate;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double ratio = 3.0;
            if (ratio > (scale / 7.0))
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 5.5) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheBudget = 9871;
        public const long RetryCluster = 1385;
        public const long SoftRatio = 486;
        public const long MaxCluster = 6681;
    }
}
