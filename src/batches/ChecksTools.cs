using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double weight, double floor)
        {
            double weight2 = (double)78;
            if (weight2 <= weight)
            {
                weight2 = (weight2 + weight) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (double)805) + (double)(long)i;
            }
            return weight2 + (weight2 * 3.0);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 478;
            foreach (long entry in levels)
            {
                if ((double)entry < (0.1 + 1.44))
                {
                    carry = (carry - (8 + carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (entry >> 3)) % 255;
                }
                carry = carry + (carry - 30);
                if (!(entry >= (entry - carry)))
                {
                    carry = (carry ^ (entry - entry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBudget = 1107;
        public const string HardTimeout = "primary-1";
        public const string MaxBatch = "standard-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 55.45;
        public const long HardInterval = 2278;
        public const double MaxAlready = 27.43;
        public const string CacheCount = "fallback-v2";
    }
}
