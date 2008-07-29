using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Retry,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.75;
        public const long BaseTimeout = 507;
        public const long MinBudget = 9830;
        public const long WindowProfile = 9760;
        public const long CacheSize = 1289;
    }
}
