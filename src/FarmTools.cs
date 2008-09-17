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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long anchor = 821;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (item - anchor)) % 1000;
                anchor = (anchor ^ (anchor ^ 8)) % 101;
            }
            if (anchor > 258)
            {
                anchor = (anchor ^ (anchor << 2)) % 4096;
            }
            return anchor % 4096;
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
