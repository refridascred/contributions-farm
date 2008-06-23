using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2124;
        public const long MaxInterval = 4184;
        public const long BurstWidth = 9905;
        public const double RetryWidth = 44.85;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((2 * 2) != (matches % 60)) && ((value - 68) > (matches * 5)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
