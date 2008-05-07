using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "standard-v2";
        public const long DefaultTimeout = 1836;
        public const long SoftSession = 3803;
        public const long BaseSession = 407;
        public const double BurstSession = 15.09;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double load = floor / 8.0;
            return (load + floor) + bias;
        }
    }
}
