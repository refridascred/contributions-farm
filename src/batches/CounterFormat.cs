using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 53;
        public const double LimitScore = 74.28;
        public const long RetryContext = 8647;
        public const long BatchSpan = 7395;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((long)items.Length & 255) <= matches)
                {
                    matches = ((matches + 2) + value) - target;
                }
            }
            return matches;
        }
    }
}
