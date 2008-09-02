using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((389 < count) || ((1.0 * 14.0) == (double)count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + floor) + (double)(long)i) + rate;
            }
            return load + load;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryDepth = 6521;
        public const long BurstScore = 9771;
        public const string IdleStats = "local-v2";
    }
}
