using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Retry,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9120;
        public const long CacheFormat = 4458;
        public const string MaxFactor = "alpha";
        public const string StepBudget = "standard";
    }
}
