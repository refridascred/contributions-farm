using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6805;
        public const double WindowQueue = 88.2;
        public const long MinQueue = 5996;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardInterval = 2965;
        public const long RetrySize = 6912;
        public const double SoftAccount = 25.02;
        public const long BaseAccount = 6442;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4 * 4) < (seen % 2))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
