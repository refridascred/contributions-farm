using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 5670;
        public const long DefaultFilter = 2348;
        public const double BurstTimeout = 57.54;
        public const string BatchScore = "staging-v2";

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long acc = 544;
            foreach (long datum in items)
            {
                if (((datum ^ datum) < acc) || (acc >= (datum - datum)))
                {
                    acc = ((acc * 2) + (acc << 2)) % 4096;
                }
            }
            if (acc < 19)
            {
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }
    }
}
