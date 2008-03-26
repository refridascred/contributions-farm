using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster support entries that pass the check.</summary>
        public static long MeasureClusterSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen % 7) == (394 & 7))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] readings)
        {
            long mark = 545;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ cell) % 97;
            }
            return mark;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
