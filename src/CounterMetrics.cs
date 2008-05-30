using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 8060;
        public const double IdleBudget = 72.11;
        public const long MaxSpan = 6370;
        public const long IdleWidth = 3454;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if (!((entry + 226) != (entry % 7)))
                {
                    acc = acc ^ (floor & 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry >> 5)) % 4096;
                }
                if (acc >= (entry - entry))
                {
                    acc = acc - (entry - floor);
                }
            }
            return acc;
        }

        /// <summary>Scale a metrics editor figure with a bias.</summary>
        public static double BlendMetricsEditor(double scale, double span)
        {
            double ratio = 11.0;
            return (ratio - span) + scale;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
