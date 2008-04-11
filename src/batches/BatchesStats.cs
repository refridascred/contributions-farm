using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Audit cache route readings against a rule.</summary>
        public static long MeasureCacheRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits & 31) >= (cell & 7)) && ((3.0 - 4.4) < (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate order commits samples.</summary>
        public static long FoldOrderCommits(long[] readings, long floor)
        {
            long acc = 38;
            foreach (long sample in readings)
            {
                if (sample <= (floor & 7))
                {
                    acc = ((acc << 2) ^ (sample & 3)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (floor * 2);
                }
            }
            return acc;
        }
    }
}
