using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Closed,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSpan = 3269;
        public const double MinRatio = 37.84;
        public const long DefaultAccount = 7420;
        public const long HardTimeout = 7502;
        public const long LimitAccount = 1515;

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((2 - limit) > (item + limit)) && (((double)item <= (0.21 * 1.97)) && ((seen << 2) >= item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool ValidateNotesOrderLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
