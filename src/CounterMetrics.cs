using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 42.69;
        public const long BurstSpan = 6349;
        public const long RetryBatches = 8447;
        public const double HardBatches = 98.75;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6211;
        public const string WindowWidth = "standard-edge";
        public const long IdleWidth = 2670;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next format counter value.</summary>
        public static double ProjectFormatCounter(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (double)761)
            {
                ratio = (ratio - 6.5) + bias2;
            }
            return ratio + bias;
        }
    }
}
