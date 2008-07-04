using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheBudget = 50.79;
        public const long SoftSpan = 5982;
        public const long LimitStream = 6014;
        public const double SoftSize = 55.79;

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftDepth = "open-1";
        public const long HardTools = 5365;
        public const double RetryRatio = 22.65;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 6538;
        public const double SoftPayload = 24.24;
        public const string StepPayload = "legacy-1";
    }
}
