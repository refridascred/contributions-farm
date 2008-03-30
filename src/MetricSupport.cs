using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
