using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Closed,
            Retry,
            Stale,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSpan = 13.18;
        public const double MinBudget = 65.75;
        public const double BaseSpan = 4.52;
        public const long BaseInterval = 7296;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(0 < (count - count)))
                {
                    count = ((count + 3) + cell) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8943;
        public const long BurstFormat = 3926;
        public const long IdleCount = 5907;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
