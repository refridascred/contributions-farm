using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value < (double)limit)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count - (long)items.Length) <= count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
