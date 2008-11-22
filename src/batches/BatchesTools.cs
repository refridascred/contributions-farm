using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values)
        {
            long mark = 436;
            foreach (long sample in values)
            {
                mark = (mark ^ mark) ^ sample;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= (double)(-738))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
