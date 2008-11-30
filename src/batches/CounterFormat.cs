using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long TallyOrderMetricsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits < (double)datum)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((1.0 * 1.5) >= (12.0 + 9.5))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
