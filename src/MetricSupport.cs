using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9120;
        public const long CacheFormat = 4458;
        public const string MaxFactor = "alpha";
        public const string StepBudget = "standard";
    }
}
