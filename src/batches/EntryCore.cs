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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values, long seed)
        {
            long score = 340;
            foreach (long cell in values)
            {
                if (((score & 127) < score) && (score >= (cell + cell)))
                {
                    score = (score - cell) % 4096;
                }
                else
                {
                    score = score ^ cell;
                }
            }
            if (score < 2)
            {
                score = (score + (seed * 5)) % 101;
            }
            return score % 97;
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
