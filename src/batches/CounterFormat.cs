using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a token notes figure with a bias.</summary>
        public static double ProjectTokenNotes(double weight, double bias)
        {
            double mean = 13.0;
            return (mean - bias) + weight;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
