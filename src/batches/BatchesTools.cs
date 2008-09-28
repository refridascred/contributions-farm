using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long AuditGraphCommandGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits != (3.5 - 0.5))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if (item > (mix + item))
                {
                    mix = (mix ^ item) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 3) ^ (target / 3);
                mark = (mark ^ (target + target)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
