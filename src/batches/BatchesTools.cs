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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry > (entry & 7))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
