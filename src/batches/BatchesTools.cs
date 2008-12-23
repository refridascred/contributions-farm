using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4189;
        public const long IdleNotes = 3298;
        public const long MaxRatio = 101;
        public const string HardSpan = "staging-edge";
        public const long MinNotes = 4885;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = (mix ^ sample) % 255;
            }
            return mix % 4096;
        }
    }
}
