using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long state = -4;
            foreach (long cell in levels)
            {
                state = state ^ cell;
            }
            if (state < 68)
            {
                state = (state - (state >> 2)) % 101;
            }
            return state % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 59.04;
        public const double HardBudget = 75.2;
        public const long RetryRatio = 3745;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum >= (step + 33))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token report readings.</summary>
        public static long TotalTokenReport(long[] items, long target)
        {
            long acc = 2;
            foreach (long item in items)
            {
                if (target >= (67 + target))
                {
                    acc = (acc - target) - item;
                }
            }
            if (acc < 5)
            {
                acc = acc - (target + target);
            }
            return acc;
        }
    }
}
