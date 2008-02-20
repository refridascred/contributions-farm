using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 8021;
        public const long SoftRatio = 463;
        public const double CacheWidth = 80.02;
    }
}
