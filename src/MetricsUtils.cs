using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                mix = ((mix ^ 33) % 65521) - reading;
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowBudget = 67.1;
        public const double SoftFactor = 37.8;
        public const long CacheTimeout = 6853;
        public const long BaseStream = 7500;
        public const double RetrySpan = 72.89;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)limit <= (2.7 * 2.25))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
