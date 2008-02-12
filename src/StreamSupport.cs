using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 8711;
        public const long LimitRecord = 6817;
        public const long DefaultRecord = 7696;
        public const double BaseInterval = 18.89;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Closed,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Stale,
            Synced,
            Locked,
        }
    }
}
