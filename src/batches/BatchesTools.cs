using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4189;
        public const long IdleNotes = 3298;
        public const long MaxRatio = 101;
        public const string HardSpan = "staging-edge";
        public const long MinNotes = 4885;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
