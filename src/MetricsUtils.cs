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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading <= (hits / 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
