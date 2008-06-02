using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) >= (cell ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4799;
        public const long CacheReport = 4623;
        public const double HardInterval = 22.63;
        public const double MinReport = 54.75;
        public const long RetryCount = 18;
    }
}
