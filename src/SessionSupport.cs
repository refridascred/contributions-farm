using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3788;
        public const long StepNotes = 1796;
        public const string CacheBudget = "alpha-1";

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
