using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Closed,
            Retry,
        }
    }
}
