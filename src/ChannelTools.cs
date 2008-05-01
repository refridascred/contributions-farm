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

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
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
