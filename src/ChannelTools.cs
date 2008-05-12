using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Dropped,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "staging-1";
        public const string DefaultOrder = "fallback-1";
        public const long MaxWidth = 288;
    }
}
