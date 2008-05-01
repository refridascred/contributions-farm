using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 1283;
        public const long BurstPayload = 9237;
        public const long CacheLevel = 6870;
        public const long MaxPayload = 3133;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Dropped,
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
