using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels, long target)
        {
            long result = 2;
            foreach (long item in levels)
            {
                result = ((result ^ (target + target)) % 4096) ^ item;
            }
            return result;
        }
    }
}
