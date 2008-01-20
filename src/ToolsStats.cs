using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the stream schema series from a seed.</summary>
        public static long DeriveStreamSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((69 << 1) == (186 ^ origin)))
                {
                    mark = (mark - (origin + 8)) % 1000;
                    mark = mark - 9;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
