using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context stream entries that pass the check.</summary>
        public static long AuditContextStreamHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-625) - matches) >= matches)
                {
                    matches = ((matches + 1) - cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((785 ^ hits) <= hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
