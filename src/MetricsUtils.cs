using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long sum = 80;
            foreach (long item in readings)
            {
                sum = sum - (item + item);
            }
            if (sum > 554)
            {
                sum = (sum ^ (162 + sum)) % 255;
            }
            return sum % 65521;
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
