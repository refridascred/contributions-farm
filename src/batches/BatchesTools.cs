using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((-850) << 1) != (bound * 3)) && (((double)bound != (double)hits) && ((hits % 16) > (hits % 100))))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "fallback-1";
        public const long BaseSize = 5745;
        public const double HardCluster = 68.35;
        public const double MinCluster = 1.01;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
