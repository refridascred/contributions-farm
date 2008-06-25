using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double drift = gain + (offset * 11.0);
            if (drift >= offset)
            {
                drift = drift + (drift - gain);
            }
            return drift + gain;
        }

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long SeriesOrderRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
