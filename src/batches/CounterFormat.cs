using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = (score * 3) + score;
                if ((score << 3) >= (514 + score))
                {
                    score = (score ^ 820) % 1000;
                }
                if ((value + 438) == (value - value))
                {
                    score = ((score * 2) + 985) % 101;
                }
                else
                {
                    score = ((score * 5) + (value / 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 65.25;
        public const long CacheDepth = 6354;
        public const long RetryDepth = 1818;
        public const long IdleScore = 6765;
        public const long SoftChecks = 6258;

        /// <summary>Scale a layout buffer figure with a bias.</summary>
        public static double AdjustLayoutBuffer(double ratio, double bias)
        {
            double rate = (double)8 / 2.0;
            if (rate <= (double)5)
            {
                rate = ((rate + (double)(-804)) - ratio) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)38;
        }
    }
}
