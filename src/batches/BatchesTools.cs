using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter account samples.</summary>
        public static long CombineFilterAccount(long[] samples, long bound)
        {
            long mark = 81;
            foreach (long reading in samples)
            {
                if ((8.72 + 10.0) == (double)bound)
                {
                    mark = (mark + (bound - mark)) ^ reading;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (bound / 3)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((17.0 - 5.1) > (double)entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry session samples are out of range.</summary>
        public static long AuditEntrySessionHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(cell <= (matches + offset)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
