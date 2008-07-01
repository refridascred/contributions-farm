using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryFactor = 51.3;
        public const long WindowGraph = 4923;
        public const double CacheGraph = 22.72;
        public const double MinGraph = 22.81;

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepTimeout = "primary-edge";
        public const long IdleLayout = 4469;
        public const long WindowLayout = 7939;
        public const long BaseCount = 6230;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5603;
        public const double MinFormat = 73.98;
        public const long RetryDepth = 293;
        public const double IdleRatio = 98.87;
    }
}
