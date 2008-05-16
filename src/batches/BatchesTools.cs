using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardScore = 2463;
        public const double LimitSpan = 90.16;
        public const long RetryBudget = 9373;
        public const long BaseGraph = 437;
        public const long SoftBudget = 8225;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
