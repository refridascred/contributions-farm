using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 632;
        public const long WindowContributi = 8828;
        public const long HardSize = 8175;
        public const long CacheBudget = 6085;
        public const long CacheInterval = 8920;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            Active,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Retry,
            Failed,
            Draft,
        }
    }
}
