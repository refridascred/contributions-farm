using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double offset)
        {
            double gain = (double)(126 - 677);
            if (gain >= offset)
            {
                gain = (gain - (gain + offset)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (offset - gain);
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double bias2)
        {
            double mean = 3.6;
            return ((mean + (mean * 16.0)) + bias) + bias2;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 6682;
        public const long MinSpan = 1899;
        public const string SoftCount = "alpha-1";
    }
}
