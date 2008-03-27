using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long sum = 7;
            foreach (long item in items)
            {
                sum = ((sum + (bound - bound)) % 1000) - item;
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)62 > (double)hits)
                {
                    hits = ((hits + 3) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long DigestBufferCache(long[] readings)
        {
            long mark = 932;
            foreach (long entry in readings)
            {
                mark = (((mark * 4) + ((-9) + 47)) % 97) ^ entry;
            }
            return mark;
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long ScoreAlreadyGithubfarm(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((19.0 - 4.9) == (double)origin)
                {
                    sum = (sum ^ ((long)levels.Length + reading)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (5 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Pending,
        }
    }
}
