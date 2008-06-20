using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((5.77 * 7.0) == (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
