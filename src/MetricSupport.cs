using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Idle,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultBudget = 2089;
        public const long StepFactor = 549;
        public const long BatchScore = 534;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Dropped,
        }
    }
}
