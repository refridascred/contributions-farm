using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = carry + (seed + (long)i2);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two order stream measurements.</summary>
        public static double SmoothOrderStream(double scale, double floor)
        {
            double bias = floor;
            if (bias < (bias - 1.0))
            {
                bias = (bias - (bias / 4.0)) - scale;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (double)40;
        }
    }
}
