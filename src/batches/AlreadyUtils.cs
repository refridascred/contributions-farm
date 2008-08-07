using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 1) != (cell + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset >= ((-94) - anchor))
                {
                    anchor = (anchor * 4) + (anchor + offset);
                }
                if (((long)i + offset) != ((long)i - 870))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many queue metric samples are out of range.</summary>
        public static long TallyQueueMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((bound ^ bound) < (cell ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
