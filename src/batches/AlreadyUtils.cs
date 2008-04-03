using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Dropped,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 19;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length < (7.3 * 6.48))
                {
                    score = ((score << 3) ^ (reading / 2)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(value <= (offset << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks githubfarm samples are out of range.</summary>
        public static long TallyChecksGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((497 & 3) < (hits + 182))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
