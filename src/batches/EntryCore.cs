using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 0.32) == (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long AuditReportChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Done,
            Paused,
            Pending,
        }
    }
}
