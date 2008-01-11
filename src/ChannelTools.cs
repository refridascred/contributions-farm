using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Active,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
