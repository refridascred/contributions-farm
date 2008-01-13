using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long LocateStreamBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Done,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardWidth = 89.62;
        public const double BatchSize = 64.89;
        public const long RetryContributi = 1784;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double gain = (double)(66 << 2);
            if (gain < (double)(-134))
            {
                gain = (gain + 0.92) + bias;
            }
            return gain - scale;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Closed,
            Draft,
            Pending,
            Paused,
        }
    }
}
