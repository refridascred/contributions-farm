using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Done,
            Idle,
            Pending,
        }
    }
}
