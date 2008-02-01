using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheRatio = "staging-1";
        public const long MinDepth = 6273;
        public const long LimitSession = 3871;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Closed,
            Done,
            New,
            Locked,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Retry,
            Locked,
            Paused,
        }
    }
}
