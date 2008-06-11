using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double bias = (double)(8 >> 4);
            if (bias > bias)
            {
                bias = ((bias + bias) - scale) - offset;
            }
            else
            {
                bias = bias - (bias - 3.0);
            }
            return bias - bias;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Draft,
            Done,
        }
    }
}
