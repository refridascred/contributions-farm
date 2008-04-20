using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell > (tally % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSpan = 661;
        public const long BurstWidth = 3880;
        public const string RetryBudget = "cached-v2";
        public const long SoftBudget = 711;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.53;
        public const long IdleAccount = 2319;
        public const string CacheDepth = "stable";
        public const string SoftAccount = "alpha-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((4 + count) <= cell)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
