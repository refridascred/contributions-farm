using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 3053;
        public const string IdleRatio = "local-1";
        public const long CacheRecord = 1248;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Locked,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
