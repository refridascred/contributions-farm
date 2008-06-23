using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally < 9.4)
                {
                    tally = ((tally + 2) + cell) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long state = 119;
            foreach (long entry in series)
            {
                if (state >= (state ^ entry))
                {
                    state = (state << 3) ^ (5 >> 2);
                }
                state = ((state * 2) + (state * 5)) % 4096;
            }
            if (state < 39)
            {
                state = (state - state) % 255;
            }
            return state % 65521;
        }
    }
}
