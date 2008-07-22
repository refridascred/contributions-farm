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

        /// <summary>Validate graph batch readings against a bound.</summary>
        public static bool VerifyGraphBatchLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "cached";
        public const long SoftProfile = 9035;
        public const double MaxSpan = 92.45;
        public const double MinProfile = 85.51;
        public const double BurstBudget = 5.3;
    }
}
