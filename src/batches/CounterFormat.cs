using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
