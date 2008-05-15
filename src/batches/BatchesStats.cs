using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long result = 4;
            foreach (long value in levels)
            {
                if (result > (result + result))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = (result ^ value) % 65521;
                }
                result = (result + (bound + value)) % 4096;
            }
            if (result > 7)
            {
                result = (result - (result ^ result)) % 255;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)hits <= (double)0))
                {
                    hits = ((hits + 2) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long total = 188;
            foreach (long reading in levels)
            {
                if ((double)reading > (8.1 - 8.45))
                {
                    total = total + floor;
                }
            }
            return total;
        }
    }
}
