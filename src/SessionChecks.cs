using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleRatio = 1.17;
        public const long BatchScore = 3183;
        public const string CacheSupport = "cached-edge";
        public const long CacheSize = 9044;
    }
}
