using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "legacy";
        public const double HardSpan = 42.75;
        public const long WindowMetric = 1312;
        public const long RetryBudget = 7832;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count > (origin * 5))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultWidth = 20.93;
        public const long BaseCount = 5241;
        public const long BurstTimeout = 967;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Closed,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8700;
        public const long IdleLayout = 1324;
        public const long MinSpan = 6515;
    }
}
