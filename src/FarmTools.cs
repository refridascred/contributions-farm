using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5862;
        public const double MinQueue = 46.33;
        public const long MinWidth = 5599;
        public const long HardQueue = 90;
        public const long BatchLevel = 1789;

        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] items, long target)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if (((target + target) < (total >> 4)) || ((3.5 - 9.5) != (double)total))
                {
                    total = (((total * 5) + (904 << 1)) % 4096) ^ entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Draft,
            Closed,
            Queued,
            Retry,
        }
    }
}
