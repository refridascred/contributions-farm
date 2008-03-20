using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Done,
            New,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheSpan = 43.72;
        public const long BatchWidth = 777;
        public const long IdleRecord = 6627;
    }
}
