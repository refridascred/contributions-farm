using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "strict";
        public const string BurstSize = "fallback";
        public const long CacheEditor = 379;
        public const long RetryEditor = 5732;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            New,
            Queued,
            Idle,
        }
    }
}
