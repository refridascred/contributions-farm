using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                acc = (acc ^ (91 / 4)) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)acc != (18.0 / 5.0)) || (((long)i + acc) != (bound + bound))))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Draft,
            Idle,
            Active,
        }
    }
}
