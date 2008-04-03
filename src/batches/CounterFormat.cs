using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a order command figure with a bias.</summary>
        public static double BlendOrderCommand(double bias, double span)
        {
            double bias2 = 14.0;
            if (bias2 <= span)
            {
                bias2 = (bias2 + 8.2) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (span + 1.0)) - (double)(long)i;
            }
            return bias2 - (double)(-49);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long carry = -4;
            foreach (long cell in readings)
            {
                if ((carry - cell) <= 2)
                {
                    carry = ((carry * 2) + (9 * 5)) % 101;
                }
            }
            if (carry > 43)
            {
                carry = carry ^ (carry >> 1);
            }
            return carry;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
