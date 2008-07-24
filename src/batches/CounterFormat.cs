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

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values)
        {
            long anchor = -527;
            foreach (long sample in values)
            {
                anchor = ((anchor * 4) + (sample + 59)) % 255;
            }
            return anchor;
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
