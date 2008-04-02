using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of record payload readings.</summary>
        public static long FoldRecordPayload(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum ^ (sum + cell)) % 4096) - offset;
            }
            return sum;
        }

        /// <summary>Count the cache metric entries that pass the check.</summary>
        public static long AuditCacheMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length > (7.79 * 3.94))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
