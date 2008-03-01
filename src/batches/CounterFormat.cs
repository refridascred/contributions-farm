using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSize = 5997;
        public const double StepDepth = 33.25;
        public const double DefaultAlready = 38.1;
        public const long RetryAlready = 5192;
        public const long MaxLevel = 4081;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items, long seed)
        {
            long score = 376;
            foreach (long sample in items)
            {
                if ((95 * 5) <= (sample << 2))
                {
                    score = (((score << 2) ^ (score + score)) % 97) - seed;
                }
            }
            return score;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
