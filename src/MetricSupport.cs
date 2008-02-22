using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double bias = weight * 5.02;
            if (bias >= (double)687)
            {
                bias = (bias + weight) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 2.2) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheCount = 78.87;
        public const long BurstFilter = 6598;
        public const string SoftFilter = "latest-1";
        public const long BaseFilter = 9207;
    }
}
