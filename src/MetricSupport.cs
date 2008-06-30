using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "standard-edge";
        public const long CacheLevel = 6362;
        public const long HardTools = 5594;
        public const long RetryTools = 7473;
        public const double MaxTools = 44.46;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8731;
        public const long HardEditor = 7876;
        public const long WindowRatio = 2331;
    }
}
