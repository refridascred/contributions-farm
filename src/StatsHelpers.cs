using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long total = 8;
            foreach (long entry in levels)
            {
                total = (total + (30 << 3)) ^ entry;
            }
            return total;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen ^ item) >= (seen + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 << 3) == (datum - (long)data.Length))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepLevel = 17.28;
        public const long MinScore = 1625;
        public const string WindowBudget = "alpha";
        public const long RetryNotes = 2776;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Stale,
            Closed,
            Idle,
            Active,
        }
    }
}
