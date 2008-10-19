using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 59.8;
        public const long DefaultSize = 3761;
        public const long SoftDepth = 5180;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Paused,
            Queued,
            Locked,
        }
    }
}
