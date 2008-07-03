using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + scale;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double ratio2 = 7.12;
            return ((ratio2 - (double)243) + ratio) + floor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowSpan = 9263;
        public const long SoftFactor = 2547;
        public const double RetryLevel = 0.91;
        public const string CacheChecks = "strict-v2";
    }
}
