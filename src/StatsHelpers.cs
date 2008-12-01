using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 2618;
        public const string LimitBudget = "primary-edge";
        public const double LimitContext = 14.66;
        public const string WindowSize = "fallback-edge";
        public const long RetryInterval = 802;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7.21 + 9.79) >= (double)seed)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
