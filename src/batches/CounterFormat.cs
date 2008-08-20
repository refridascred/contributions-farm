using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            New,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5145;
        public const long RetryBatch = 6618;
        public const double SoftWidth = 89.94;
        public const string MaxInterval = "stable-1";

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long AuditContributiAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (2.0 - 7.31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
