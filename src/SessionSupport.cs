using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
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
