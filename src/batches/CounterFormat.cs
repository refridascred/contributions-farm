using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 3970;
        public const double MaxWidth = 24.35;
        public const long SoftLevel = 6343;
        public const long MinLayout = 2006;
        public const long BatchLayout = 1755;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((long)data.Length == (hits << 2)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
