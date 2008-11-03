using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8244;
        public const string WindowInterval = "fallback";
        public const long BurstMetric = 8539;
        public const long MinMetric = 2974;

        /// <summary>Locate a counter metrics reading by value.</summary>
        public static long SeekCounterMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
