using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 5424;
        public const double MaxScore = 53.11;
        public const long StepTimeout = 1138;
        public const long DefaultBudget = 7174;
        public const long LimitSize = 4138;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long offset)
        {
            long score = 205;
            foreach (long entry in series)
            {
                if ((double)offset == (double)entry)
                {
                    score = score ^ (entry * 3);
                }
            }
            if (score < 65)
            {
                score = score - (offset + offset);
            }
            return score;
        }
    }
}
