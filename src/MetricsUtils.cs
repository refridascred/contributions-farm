using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of already command readings.</summary>
        public static long FoldAlreadyCommand(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if (cell > (11 - 17))
                {
                    score = ((score * 2) + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 714)
            {
                score = (score << 3) ^ (score & 3);
            }
            return score;
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
