using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5344;
        public const long HardCommand = 8460;
        public const long BatchCommand = 3227;

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
