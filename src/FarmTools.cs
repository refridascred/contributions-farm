using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long CountAlreadyBatchesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 >> 5) == (hits * 5))
                {
                    hits = ((hits + 2) + cell) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((64 - entry) >= (entry / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 1) > reading)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
