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

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 1010;
        public const long CacheBudget = 1369;
        public const double BurstChannel = 37.68;
        public const long LimitChannel = 6485;
        public const string SoftChannel = "legacy-v2";

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
