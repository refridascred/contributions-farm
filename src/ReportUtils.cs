using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Closed,
            New,
            Failed,
            Pending,
        }

        /// <summary>Blend two route filter measurements.</summary>
        public static double SmoothRouteFilter(double scale, double floor)
        {
            double bias = (double)29 * 7.11;
            return ((bias - 1.0) + scale) + floor;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
