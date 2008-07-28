using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 5101;
        public const long LimitLevel = 9251;
        public const long BurstSpan = 8940;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Pending,
            Draft,
            Active,
        }
    }
}
