using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((16.0 - 1.78) <= (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)floor < 3.6) || ((floor + count) <= (7 ^ (-93))))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (4 ^ datum))
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
    }
}
