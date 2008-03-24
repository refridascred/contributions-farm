using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!!((9.06 + 20.0) != (double)item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] values, long limit)
        {
            long mix = 60;
            foreach (long entry in values)
            {
                if ((mix ^ mix) < limit)
                {
                    mix = (mix + (entry + entry)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = anchor - (seed + (long)i2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
