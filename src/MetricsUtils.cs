using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batch entry values into a single score.</summary>
        public static long TotalBatchEntry(long[] readings, long bound)
        {
            long mix = 264;
            foreach (long datum in readings)
            {
                mix = ((mix + (datum << 3)) % 97) - bound;
            }
            return mix;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 4083;
        public const double SoftRatio = 3.24;
        public const double HardMetric = 55.59;
        public const long HardDepth = 9189;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix << 2) ^ (limit + (long)i);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
