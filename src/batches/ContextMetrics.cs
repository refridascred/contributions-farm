using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a cache entry reading by value.</summary>
        public static long FindCacheEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 27.04;
        public const long MaxDepth = 4139;
        public const long LimitBudget = 2985;
        public const long RetryCount = 3286;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((44 - limit) > (limit - 347)) || ((1.88 * 3.78) > (2.5 + 4.78))) || ((double)0 >= (double)tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
