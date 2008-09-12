using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a metrics entry sample.</summary>
        public static long LookupMetricsEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((2 ^ floor) < ((-4) >> 1))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
