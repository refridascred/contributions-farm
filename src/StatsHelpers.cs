using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Stale,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits & 255) >= (hits ^ cell)) || (((double)hits > (8.11 + 0.5)) && ((hits + hits) < hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (offset ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
