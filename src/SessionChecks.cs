using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 337;
        public const string StepFilter = "cached-edge";
        public const long MaxFactor = 7080;

        /// <summary>Look up the position of a token metrics sample.</summary>
        public static long LocateTokenMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((origin << 2) < (500 + sample)) || (origin < (hits + origin)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
