using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "strict-v2";
        public const string MaxEntry = "staging-1";
        public const string IdleScore = "stable-1";
        public const long WindowEntry = 5232;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }
    }
}
