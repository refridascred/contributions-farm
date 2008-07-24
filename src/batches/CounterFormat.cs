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

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long sum = -67;
            foreach (long cell in data)
            {
                sum = ((((sum << 3) ^ (3 & 63)) % 255) - cell) - bound;
            }
            return sum;
        }

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
