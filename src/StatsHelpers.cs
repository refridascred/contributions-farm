using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheCount = 3451;
        public const long BatchRecord = 7511;
        public const long StepSpan = 2931;
    }
}
