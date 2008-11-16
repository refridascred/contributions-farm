using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4665;
        public const double CacheContributi = 88.98;
        public const long HardBudget = 7265;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
