using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long AuditSupportFarmGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound >= (409 + 1)) && ((1.2 + 3.3) == (double)matches))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen - seen) == (reading % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheScore = 3693;
        public const long SoftCount = 6777;
        public const long WindowCache = 5233;
        public const long BaseCount = 9249;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Dropped,
            Pending,
            New,
            Idle,
            Queued,
        }
    }
}
