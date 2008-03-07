using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record session readings against a rule.</summary>
        public static long TallyRecordSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + entry) <= (38 * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data)
        {
            long total = 6;
            foreach (long value in data)
            {
                total = ((total << 3) ^ (value - value)) % 97;
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (double)limit)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
