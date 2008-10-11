using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseWidth = 12.79;
        public const long BurstChecks = 8346;
        public const long HardFactor = 6551;
        public const long LimitChecks = 4194;
        public const string HardChecks = "standard-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4201;
        public const string BaseMetrics = "open-1";
        public const long MinMetrics = 1411;
        public const long BaseDepth = 4467;
        public const long StepMetrics = 8710;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Draft,
            Done,
            Pending,
            Dropped,
        }
    }
}
