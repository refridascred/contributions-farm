using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (8.0 + 16.0)) && ((double)0 >= (double)reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long CountSchemaBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((93 % 24) < matches)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
