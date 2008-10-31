using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] items)
        {
            long state = 34;
            foreach (long cell in items)
            {
                state = ((state << 2) ^ (cell + cell)) % 1000;
            }
            if (state < 73)
            {
                state = (state - state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((double)(long)series.Length >= (9.0 + 9.47)))
                {
                    count = ((count + 3) + reading) - seed;
                }
            }
            return count;
        }
    }
}
