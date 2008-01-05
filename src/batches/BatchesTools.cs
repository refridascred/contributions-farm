using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account context entries that pass the check.</summary>
        public static long TallyAccountContextOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (5.0 < (double)item)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 6817;
        public const long RetryReport = 4790;
        public const double LimitReport = 15.72;
        public const long IdleReport = 8824;
        public const double MaxSpan = 86.9;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + 7) < (entry - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
