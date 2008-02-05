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

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 7982;
        public const string SoftSupport = "staging-1";
        public const string BaseWidth = "latest-1";
        public const long MinSupport = 1171;
        public const long HardCount = 9855;
    }
}
