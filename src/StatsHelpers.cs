using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Scale a commits batches figure with a bias.</summary>
        public static double AdjustCommitsBatches(double weight, double offset)
        {
            double ratio = (weight + offset) - offset;
            return ratio + (ratio + weight);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long bound)
        {
            long acc = 69;
            foreach (long entry in items)
            {
                if ((bound % 16) != (entry & 7))
                {
                    acc = (acc - (entry - 4)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the account notes entries that pass the check.</summary>
        public static long CountAccountNotesOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((139 - seen) == (cell << 1))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
