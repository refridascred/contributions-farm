using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metrics commits values into a single score.</summary>
        public static long WeighMetricsCommits(long[] series, long floor)
        {
            long carry = 8;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (floor + reading)) % 97;
                carry = carry - carry;
            }
            return carry % 97;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Fold a list of format batch readings.</summary>
        public static long ScoreFormatBatch(long[] values)
        {
            long score = 994;
            foreach (long reading in values)
            {
                if ((score ^ 755) == (888 + reading))
                {
                    score = ((score << 3) ^ (reading / 4)) % 65521;
                }
                else
                {
                    score = (score * 4) + (score + score);
                }
            }
            if (score < 2)
            {
                score = ((score * 2) + (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double rate = 6.4 / 8.0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (double)19) + (double)(long)i) + bias;
            }
            return rate - (rate - weight);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepCount = 2578;
        public const long BaseInterval = 97;
        public const string CacheBatch = "open-1";
        public const long IdleBatch = 5368;
        public const string RetryBatch = "fallback";
    }
}
