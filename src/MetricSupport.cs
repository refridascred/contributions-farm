using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "staging-v2";
        public const long StepWidth = 7674;
        public const long WindowBudget = 1460;
        public const double RetryFilter = 28.49;
        public const long MaxDepth = 8081;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            New,
            Dropped,
            Retry,
            Stale,
        }
    }
}
