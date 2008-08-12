using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleBudget = 1586;
        public const double MaxLevel = 90.77;
        public const string LimitLevel = "alpha-1";

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long limit)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (sample % 8)) % 101;
            }
            if (sum > 3)
            {
                sum = ((sum << 2) ^ (limit << 2)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
