using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
