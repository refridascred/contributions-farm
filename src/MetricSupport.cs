using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 5992;
        public const long MaxNotes = 2990;
        public const long BaseRatio = 7438;
        public const long CacheLevel = 678;
        public const long MinNotes = 8884;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long anchor = 700;
            foreach (long entry in samples)
            {
                if ((55 - seed) >= seed)
                {
                    anchor = (((anchor * 2) + (seed + seed)) % 255) - entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
