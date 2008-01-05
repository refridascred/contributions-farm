using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Queued,
            Draft,
            New,
            Locked,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Stale,
            New,
        }
    }
}
