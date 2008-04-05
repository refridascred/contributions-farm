using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8699;
        public const double HardRatio = 67.4;
        public const long RetryReport = 373;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (origin + origin);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
