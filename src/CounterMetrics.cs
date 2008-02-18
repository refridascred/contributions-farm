using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long total = 87;
            foreach (long sample in samples)
            {
                total = total + (sample % 5);
                total = total + (sample ^ total);
            }
            if (total > 219)
            {
                total = ((total * 5) + (limit + (long)samples.Length)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 5; i++)
            {
                scale2 = ((scale2 - 5.74) + (double)(long)i) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Flag { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
