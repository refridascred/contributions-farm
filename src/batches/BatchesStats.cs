using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 1942;
        public const long BatchScore = 447;
        public const long CacheBudget = 3124;
        public const double DefaultMetrics = 96.4;
        public const long CacheInterval = 2789;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((196 + 75) >= (tally - 2)) || ((tally - tally) > (entry - entry))) || ((entry & 127) > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally + tally) != (tally << 2)) && ((14.0 * 7.2) > (double)(long)samples.Length)) || (((5 << 1) > tally) || ((2 + tally) == (sample * 5))))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
