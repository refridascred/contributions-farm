using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 8012;
        public const long LimitMetric = 3130;
        public const long BaseSize = 7453;
        public const string RetrySpan = "staging-v2";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double scale = ratio;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (scale * 0.5)) + (double)(long)i) - floor;
            }
            return scale - 9.84;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
