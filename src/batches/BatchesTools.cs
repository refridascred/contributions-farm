using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Retry,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheSpan = "strict-edge";
        public const long MinEntry = 4785;
        public const double StepEntry = 30.87;
        public const string StepCount = "local-1";
    }
}
