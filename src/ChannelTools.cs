using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
