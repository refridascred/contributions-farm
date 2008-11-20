using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Dropped,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long CountRecordReportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((floor % 100) < (floor - 8))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
