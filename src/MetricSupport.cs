using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Locked,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseBudget = 9586;
        public const string BatchSchema = "fallback-1";
        public const long CacheCount = 9275;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "staging-edge";
        public const long IdleReport = 9687;
        public const long RetryTimeout = 4515;
        public const double BaseReport = 96.92;
    }
}
