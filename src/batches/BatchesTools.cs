using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + matches) >= (matches - (-4)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((3 & 255) <= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
