using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                if (9.0 >= (double)acc)
                {
                    acc = ((acc ^ (datum - datum)) % 1000) + floor;
                }
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
