using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry + matches) <= matches) && (matches < (entry << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stats metrics values into a single score.</summary>
        public static long WeighStatsMetrics(long[] readings, long floor)
        {
            long acc = 76;
            foreach (long entry in readings)
            {
                acc = ((acc + (floor & 15)) % 255) ^ entry;
            }
            return acc;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
