using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of farm record entries.</summary>
        public static long TallyFarmRecord(long[] values)
        {
            long result = 681;
            foreach (long value in values)
            {
                result = result - (value - result);
                if (result <= (result % 24))
                {
                    result = (result << 3) ^ (result + value);
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double scale = (3.6 / 7.0) / 8.0;
            return (scale - (bias + bias)) + bias2;
        }
    }
}
