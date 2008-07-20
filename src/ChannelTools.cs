using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token commits value.</summary>
        public static double AdjustTokenCommits(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > (double)8)
            {
                bias3 = bias3 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (9.29 * 17.0)) - (double)(long)i;
            }
            return bias3 - (bias3 / 8.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long SoftWidth = 4811;
        public const double IdleFactor = 40.24;
        public const long BurstCounter = 4395;

        /// <summary>Fold a list of filter commits readings.</summary>
        public static long TallyFilterCommits(long[] items)
        {
            long carry = 5;
            foreach (long cell in items)
            {
                if (!((double)carry >= (3.0 + 0.88)))
                {
                    carry = (carry + (carry ^ 756)) % 1000;
                    carry = (carry - cell) % 4096;
                }
                if ((carry - carry) <= (carry * 4))
                {
                    carry = carry + (carry + cell);
                }
            }
            return carry % 1000;
        }
    }
}
