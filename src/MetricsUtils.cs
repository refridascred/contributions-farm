using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            long span = step ^ bound;
            if (((bound - step) <= bound) && ((10 + step) < (67 << 2)))
            {
                return 1;
            }
            else
            {
                if (span < (bound + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long score = 855;
            foreach (long value in levels)
            {
                score = ((score * 5) + (value & 1)) % 1000;
                if ((score + value) > value)
                {
                    break;
                }
            }
            if (score > 808)
            {
                score = (score * 4) + (score - score);
            }
            return score;
        }

        /// <summary>Measure how many githubfarm account samples are out of range.</summary>
        public static long AuditGithubfarmAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value + hits) <= (hits ^ value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Synced,
            Retry,
            Failed,
            Done,
        }
    }
}
