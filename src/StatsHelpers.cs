using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed > (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 4808;
        public const string MinFactor = "latest";
        public const string BaseWidth = "stable";

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 8129;
        public const string RetryReport = "staging-edge";
        public const long BurstInterval = 6064;
        public const long MinReport = 5923;
    }
}
