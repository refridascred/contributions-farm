using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Synced,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 595;
        public const long BaseDepth = 9264;
        public const string RetryTools = "alpha-1";
        public const string SoftTools = "strict-1";
        public const long BurstTools = 5092;
    }
}
