using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Ready,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Adjust a route metrics reading.</summary>
        public static double SmoothRouteMetrics(double weight, double bias)
        {
            double load = weight;
            if (load > (load * 5.0))
            {
                load = (load - load) + bias;
            }
            return load - weight;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "staging";
        public const long CacheSession = 1367;
        public const long HardRatio = 1850;
    }
}
