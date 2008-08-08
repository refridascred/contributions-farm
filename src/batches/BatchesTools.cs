using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((matches << 2) <= (514 ^ matches)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
            Active,
            Dropped,
        }
    }
}
