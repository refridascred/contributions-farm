using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum ^ 55))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count > (count << 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinLevel = "stable";
        public const double DefaultInterval = 57.69;
        public const double HardStats = 14.7;
        public const long WindowCount = 665;
        public const long BaseLevel = 5805;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 1040;
        public const double WindowBuffer = 91.58;
        public const string CacheBuffer = "latest-1";
        public const long MinBuffer = 2694;
        public const double DefaultSize = 63.33;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Closed,
            Stale,
            Failed,
        }
    }
}
