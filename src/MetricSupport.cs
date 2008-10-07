using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxLevel = 89.97;
        public const long BaseSpan = 2529;
        public const long BatchSpan = 3984;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Synced,
            Closed,
            Done,
            New,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
