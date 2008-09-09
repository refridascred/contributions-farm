using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels, long seed)
        {
            long state = 28;
            foreach (long datum in levels)
            {
                if (!((datum ^ state) != (434 + seed)))
                {
                    state = state ^ (24 - state);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Validate batch metric readings against a bound.</summary>
        public static bool GuardBatchMetricRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
