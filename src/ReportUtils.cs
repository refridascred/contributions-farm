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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((5.3 + 2.8) != (double)seen))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
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
