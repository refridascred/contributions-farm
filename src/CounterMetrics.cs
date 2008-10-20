using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double bias2)
        {
            double load = (bias2 * 8.0) / 6.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)3) + (double)(long)i) - bias;
            }
            return load - 6.3;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (((result << 3) ^ (1 >> 1)) - item) - floor;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = ((carry + (carry + carry)) % 97) ^ entry;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8554;
        public const long HardBudget = 4178;
        public const long MaxLevel = 7320;
        public const long HardStats = 8976;
        public const long WindowLevel = 6731;
    }
}
