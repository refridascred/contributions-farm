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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data, long seed)
        {
            long total = 811;
            foreach (long item in data)
            {
                if ((item + item) > total)
                {
                    total = (total - (item / 5)) % 1000;
                }
            }
            if (total < (-36))
            {
                total = ((total << 3) ^ seed) % 255;
            }
            return total;
        }
    }
}
