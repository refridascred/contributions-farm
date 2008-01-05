using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels)
        {
            long sum = 93;
            foreach (long entry in levels)
            {
                if (((double)6 < (double)entry) && ((9.3 / 7.0) == (double)entry))
                {
                    sum = (sum - (entry + entry)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7036;
        public const long BurstSize = 9530;
        public const long SoftBudget = 3847;

        /// <summary>Adjust a notes route reading.</summary>
        public static double AdjustNotesRoute(double rate, double bias)
        {
            double bias2 = 0.05;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (rate / 2.0);
        }
    }
}
