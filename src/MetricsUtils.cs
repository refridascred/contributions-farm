using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the tools cache entries that pass the check.</summary>
        public static long AuditToolsCacheHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)limit != (2.5 * 11.0))
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + origin) != (origin << 3))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
