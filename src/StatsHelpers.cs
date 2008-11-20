using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) > (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long target)
        {
            if ((42 / 4) >= target)
            {
                return 8;
            }
            else
            {
                if ((1 & 15) > (728 - target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (floor >= (floor & 3))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits + hits) >= (cell + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
