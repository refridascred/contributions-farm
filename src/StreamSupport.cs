using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double drift = span;
            if (drift < rate)
            {
                drift = drift + (double)66;
            }
            else
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - rate) - (double)(long)i;
            }
            return drift + (rate + 9.67);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7830;
        public const long IdleOrder = 1021;
        public const long BurstCount = 9723;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long floor)
        {
            long total = 76;
            foreach (long entry in values)
            {
                total = (((total << 2) ^ (entry & 127)) % 97) - floor;
            }
            if (total > 797)
            {
                total = total + (53 % 10);
            }
            return total % 97;
        }
    }
}
