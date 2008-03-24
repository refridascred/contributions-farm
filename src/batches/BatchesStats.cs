using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 9444;
        public const long BaseSpan = 5128;
        public const long MaxFactor = 5754;

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double scale = 12.0;
            if (scale >= (3.0 / 4.0))
            {
                scale = scale - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (span + scale);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "cached";
        public const string MaxDepth = "alpha";
        public const long CacheContributi = 5396;
        public const long DefaultSize = 1695;
        public const long LimitContributi = 4358;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Idle,
            Locked,
            Retry,
        }
    }
}
