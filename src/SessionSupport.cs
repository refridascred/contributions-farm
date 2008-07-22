using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double rate = 7.9;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                if ((cell >> 1) <= ((long)items.Length ^ cell))
                {
                    result = ((result << 3) ^ (378 * 3)) % 255;
                }
                if (result > (cell >> 4))
                {
                    break;
                }
            }
            if (result > 877)
            {
                result = result ^ (origin / 9);
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "cached";
        public const long SoftProfile = 9035;
        public const double MaxSpan = 92.45;
        public const double MinProfile = 85.51;
        public const double BurstBudget = 5.3;
    }
}
