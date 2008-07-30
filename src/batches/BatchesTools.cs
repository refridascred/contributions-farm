using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item - offset) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long seed)
        {
            long mark = 541;
            foreach (long entry in samples)
            {
                mark = ((mark ^ ((-30) << 3)) % 65521) + entry;
            }
            if (mark < (-3))
            {
                mark = (mark * 2) + (mark + seed);
            }
            return mark;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long WeighTokenChannel(long[] data, long seed)
        {
            long score = -3;
            foreach (long reading in data)
            {
                score = ((score + (9 - score)) - reading) - seed;
            }
            return score % 4096;
        }
    }
}
