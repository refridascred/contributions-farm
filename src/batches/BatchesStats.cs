using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!!((tally + 8) > (target / 3)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + target) <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                if ((7.61 / 7.0) > (double)acc)
                {
                    acc = ((acc + (acc * 5)) % 4096) - datum;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 97;
                }
            }
            return acc;
        }
    }
}
