using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool CheckTokenContributiBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches <= value) || ((double)value >= 19.0)) && !((target + target) != (matches >> 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftWidth = 66.18;
        public const double StepTimeout = 49.66;
        public const string RetryCommits = "staging-edge";
        public const double LimitFactor = 40.13;
    }
}
