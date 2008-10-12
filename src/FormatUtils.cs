using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (target < (784 >> 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long offset)
        {
            long result = 429;
            foreach (long reading in values)
            {
                result = (((result * 4) + (result << 1)) + reading) + offset;
            }
            return result;
        }

        /// <summary>Count the entry cluster entries that pass the check.</summary>
        public static long AuditEntryClusterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count + 353) > (value + count)) || ((value >= (value + count)) || (value >= (value << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (double)(long)levels.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (origin <= count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the cache channel entries that pass the check.</summary>
        public static long TallyCacheChannelOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + matches) < (value + value))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
