using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 7.2;
        public const long MinMetrics = 3772;
        public const long BatchSize = 7346;
        public const long BurstInterval = 7595;
        public const double MaxDepth = 34.95;

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 53.73;
        public const double BurstCache = 69.36;
        public const long RetryCache = 700;
    }
}
