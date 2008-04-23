using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Closed,
            Failed,
            Done,
        }
    }
}
