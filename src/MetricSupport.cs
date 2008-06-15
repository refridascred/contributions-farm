using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9991;
        public const long MaxWidth = 4714;
        public const string BurstWidth = "fallback-edge";

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double load = 2.26;
            return (load + (4.0 + scale)) + floor;
        }
    }
}
