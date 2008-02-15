using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a counter contributi figure with a bias.</summary>
        public static double ProjectCounterContributi(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 - (double)(-5)) + bias;
        }
    }
}
