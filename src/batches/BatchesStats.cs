using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (double)756)
            {
                weight2 = (weight2 + (bias * 4.0)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)(-789)) + (double)(long)i;
            }
            return weight2 + bias;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowWidth = 4106;
        public const long BatchDepth = 7475;
        public const long RetryScore = 5611;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
