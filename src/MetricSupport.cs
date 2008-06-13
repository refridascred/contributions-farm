using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 59.02;
        public const long LimitRatio = 3232;
        public const string RetryInterval = "stable";
        public const long SoftProfile = 4354;

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 3254;
        public const long BurstTimeout = 5500;
        public const string BaseFormat = "fallback";
        public const long BaseInterval = 7167;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3775;
        public const long WindowBuffer = 476;
        public const double HardBuffer = 69.92;
        public const string BaseBuffer = "staging-v2";
    }
}
