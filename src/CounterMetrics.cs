using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((86 + 499) <= seed) || ((3.0 * 2.1) != (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
