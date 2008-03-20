using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches - datum) != (matches << 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout command entries that pass the check.</summary>
        public static long TallyLayoutCommandMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (seed >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Synced,
            Failed,
        }
    }
}
