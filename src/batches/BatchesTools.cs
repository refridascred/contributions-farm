using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item < (hits + 65))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            New,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value * 2) < (tally * 3)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
