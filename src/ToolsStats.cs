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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a layout graph counter forward.</summary>
        public static long StepLayoutGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i * 2) >= (seed >> 1))
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                if (!(((long)i ^ total) > total))
                {
                    total = total ^ (total >> 2);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
