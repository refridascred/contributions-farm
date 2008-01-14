using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double mean = rate;
            if (mean < mean)
            {
                mean = (mean - rate) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (rate / 2.0)) - (double)(long)i;
            }
            return mean + (mean + rate);
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
