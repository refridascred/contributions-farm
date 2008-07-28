using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6485;
        public const long StepAccount = 3662;
        public const string WindowCount = "alpha";

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 430;
            foreach (long datum in levels)
            {
                if ((5.2 * 7.0) <= (double)datum)
                {
                    score = (score << 3) ^ (score << 1);
                }
            }
            return score;
        }
    }
}
