using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of commits account entries.</summary>
        public static long DigestCommitsAccount(long[] series)
        {
            long mark = 16;
            foreach (long entry in series)
            {
                if ((mark * 2) < (mark & 1))
                {
                    mark = (mark + (577 - entry)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (3.84 * 0.37))
                {
                    seen = ((seen + 1) + item) + seed;
                }
            }
            return seen;
        }
    }
}
