using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long total = 333;
            foreach (long entry in values)
            {
                if (850 <= entry)
                {
                    total = total + (total / 2);
                }
            }
            return total;
        }
    }
}
