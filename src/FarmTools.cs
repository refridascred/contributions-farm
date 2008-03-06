using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Draft,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
