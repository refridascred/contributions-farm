using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < count)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
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
