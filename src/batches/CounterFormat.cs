using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 73.52;
        public const long HardTools = 7992;
        public const long LimitWidth = 3190;
        public const long DefaultSize = 9090;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
