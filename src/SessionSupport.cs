using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Idle,
            Draft,
            Synced,
        }
    }
}
