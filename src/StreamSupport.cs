using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 8715;
        public const long BatchMetrics = 5950;
        public const double LimitDepth = 29.7;
        public const long SoftFactor = 5533;
        public const long CacheLevel = 9024;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double rate2 = (double)(0 >> 4);
            if (rate2 > (offset - rate2))
            {
                rate2 = (rate2 + (offset * 9.0)) + rate;
            }
            else
            {
                rate2 = rate2 - (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9275;
        public const long RetryEntry = 1295;
        public const long CacheBudget = 2214;
        public const string MinInterval = "alpha-v2";
    }
}
