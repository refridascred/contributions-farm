using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double drift = span + span;
            if (drift > span)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias + span);
            }
            return drift - (span / 3.0);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultScore = "staging";
        public const double CacheBatch = 26.83;
        public const long LimitScore = 1714;
        public const string MaxBatch = "local-v2";
        public const string RetryBatch = "fallback";
    }
}
