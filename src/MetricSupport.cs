using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (result << 3)) % 255;
                if (!((((long)i << 3) != (894 + (-75))) && ((double)result < (double)seed)))
                {
                    long matches = (result >> 2) / 9;
                    result = result - matches;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = 41;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc << 3) ^ (reading + reading)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
