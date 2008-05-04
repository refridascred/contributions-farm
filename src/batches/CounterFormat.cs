using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] values, long seed)
        {
            long total = 2;
            foreach (long cell in values)
            {
                if ((cell & 31) >= (total % 2))
                {
                    total = total ^ (seed - total);
                }
                else
                {
                    total = (total - (80 - 86)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double mean = offset;
            if (mean > 16.0)
            {
                mean = (mean - (offset + mean)) + scale;
            }
            return mean + (mean - 17.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
