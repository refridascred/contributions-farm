using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double bias2 = (double)95;
            return ((bias2 + (double)887) + scale) + bias;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9268;
        public const long HardWidth = 6532;
        public const long IdleToken = 2306;
        public const long RetryToken = 1691;
    }
}
