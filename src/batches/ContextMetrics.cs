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

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long CountFarmContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) >= (seen >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue token reading by value.</summary>
        public static long LookupQueueTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
