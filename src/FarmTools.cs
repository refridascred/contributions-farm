using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
