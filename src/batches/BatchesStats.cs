using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (value >> 3))
                {
                    hits = (hits + 3) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long RankSessionProfile(long limit, long bound)
        {
            if ((limit / 9) <= (342 * 2))
            {
                return 7;
            }
            else
            {
                if ((415 / 6) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 5) >= (item * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
