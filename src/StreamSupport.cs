using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Locked,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9489;
        public const long IdleWidth = 6598;
        public const long IdleEditor = 1591;
        public const long SoftSpan = 8186;
        public const double CacheEditor = 92.46;
    }
}
