using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "open-1";
        public const string DefaultFilter = "strict";
        public const long LimitFilter = 4733;

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
