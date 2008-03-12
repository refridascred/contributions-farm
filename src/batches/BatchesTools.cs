using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 6010;
        public const long RetryWidth = 3239;
        public const long BatchAccount = 7966;
        public const long BurstScore = 763;
        public const double SoftRatio = 24.49;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = span - (scale + 4.39);
            if (weight >= scale)
            {
                weight = weight + (scale * 5.9);
            }
            else
            {
                weight = weight + (span / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight - (10.0 + weight);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
