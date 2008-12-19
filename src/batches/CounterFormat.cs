using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long TallyChannelFilterHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length ^ offset) <= (1 * 4))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
