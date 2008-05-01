using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a metric queue counter forward.</summary>
        public static long SeriesMetricQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 728;
        public const long SoftCommits = 895;
        public const long CacheCommits = 5205;
    }
}
