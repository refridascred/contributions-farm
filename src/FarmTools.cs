using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate graph account samples.</summary>
        public static long FoldGraphAccount(long[] samples)
        {
            long acc = 335;
            foreach (long entry in samples)
            {
                acc = (((acc * 4) + acc) % 1000) - entry;
            }
            return acc;
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long CountBufferMetricGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.6 > (double)target)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
