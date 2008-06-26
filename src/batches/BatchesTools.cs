using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4.0 - 9.1) > (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
