using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((8.0 - 1.29) >= (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 1933;
        public const long BatchSession = 2957;
        public const long CacheSession = 8963;
        public const long RetrySession = 7443;
        public const long MaxDepth = 6868;
    }
}
