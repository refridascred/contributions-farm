using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 442;
        public const long CacheSize = 8353;
        public const long BaseNotes = 9574;
        public const long IdleNotes = 1787;
        public const long BaseSpan = 7989;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
