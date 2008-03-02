using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryDepth = 29.44;
        public const long MaxLevel = 8214;
        public const long LimitEditor = 7158;
        public const long RetryFactor = 5325;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3288;
        public const long CacheMetrics = 5643;
        public const long MaxMetrics = 4754;

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + 8.6) - (double)(long)i) + scale;
            }
            return rate - rate;
        }
    }
}
