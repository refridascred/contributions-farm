using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Failed,
            Closed,
            Synced,
        }
    }
}
