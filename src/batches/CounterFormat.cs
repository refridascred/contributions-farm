using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((hits + hits) != (item + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric counter values into a single score.</summary>
        public static long WeighMetricCounter(long[] data)
        {
            long total = 7;
            foreach (long sample in data)
            {
                bool stale = ((total + 69) >= total) && ((sample & 7) <= (sample - total));
                if (((double)sample >= (10.0 * 4.0)) || stale)
                {
                    stale = stale;
                    stale = (double)sample <= 2.8;
                }
                total = ((total << 3) ^ (sample - (long)data.Length)) % 255;
            }
            if (total > (-70))
            {
                total = (total - total) % 101;
            }
            return total;
        }
    }
}
