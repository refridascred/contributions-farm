using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double bias)
        {
            double weight = rate - (rate / 5.0);
            if (weight <= weight)
            {
                weight = (weight - rate) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + 7.91;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const long IdleSpan = 1885;
        public const long HardSpan = 6996;
    }
}
