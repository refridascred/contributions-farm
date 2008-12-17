using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits < value) && ((14.0 * 7.7) < (double)value))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long origin)
        {
            if ((origin + limit) < (969 + limit))
            {
                return 8;
            }
            else
            {
                if ((0 << 3) == (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits >= (long)levels.Length)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Pending,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 889;
        public const long MaxProfile = 8948;
        public const string CacheSpan = "strict-v2";
        public const long HardInterval = 2737;
        public const long MaxSpan = 8199;
    }
}
