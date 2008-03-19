using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Failed,
            Done,
            New,
            Pending,
        }

        /// <summary>Project the next notes format value.</summary>
        public static double ScaleNotesFormat(double ratio, double bias)
        {
            double weight = bias;
            if (weight < ratio)
            {
                weight = weight - (double)992;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (5.2 / 8.0)) + (double)(long)i;
            }
            return weight - (8.2 - weight);
        }
    }
}
