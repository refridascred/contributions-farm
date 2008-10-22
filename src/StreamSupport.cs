using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 1397;
        public const long BatchSpan = 3832;
        public const long IdleChannel = 8473;
        public const long MinChannel = 9234;
        public const long BaseChannel = 8775;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
