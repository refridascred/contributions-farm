using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(item <= (54 / 9)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ (bound * 3);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
