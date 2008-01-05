using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryTimeout = 3402;
        public const long CacheRatio = 7440;
        public const long RetryWidth = 9411;
        public const string BatchDepth = "fallback-v2";
        public const double HardBudget = 14.51;

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
