using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double ratio = (double)(16 & 7);
            if (ratio >= span)
            {
                ratio = (ratio - ratio) - weight;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (17.0 * 1.36);
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardSize = 80.77;
        public const double RetryLevel = 98.9;
        public const double BaseSpan = 56.37;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Total { get; set; }
            public long Count { get; set; }
        }
    }
}
