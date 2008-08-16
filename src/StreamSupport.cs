using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 3001;
        public const long LimitGraph = 7458;
        public const long IdleGraph = 9080;
        public const long LimitSpan = 1860;
        public const long CacheGraph = 2130;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }
    }
}
