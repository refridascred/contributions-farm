using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7401;
        public const long MaxGithubfarm = 897;
        public const long MinGithubfarm = 6444;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (2.5 - 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long offset)
        {
            if ((double)offset >= (2.91 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((offset << 2) <= offset) || (11 < offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 4) == (9 & 63))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
