using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Idle,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Closed,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
