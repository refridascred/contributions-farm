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

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Queued,
            Failed,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }
    }
}
