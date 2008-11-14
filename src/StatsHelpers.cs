using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ 3) <= (datum % 5))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long floor)
        {
            if ((double)426 > (9.58 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((1.72 / 9.0) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!(0.41 < (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long AuditCommitsWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches >> 2) <= target)
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6661;
        public const double MaxRatio = 77.16;
        public const long RetryCount = 8885;
        public const long BurstSize = 177;
    }
}
