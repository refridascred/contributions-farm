using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Synced,
            Stale,
        }
    }
}
