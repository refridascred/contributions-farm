using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSpan = 751;
        public const long BatchCluster = 5302;
        public const string HardWidth = "staging-v2";
    }
}
