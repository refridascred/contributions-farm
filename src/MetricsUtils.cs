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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)state < (14.0 + 14.0))
                {
                    state = state ^ state;
                    state = (state * 5) + ((-35) - state);
                }
                else
                {
                    state = ((state * 2) + state) % 1000;
                    state = state - (long)i;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
