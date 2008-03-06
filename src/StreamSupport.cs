using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of checks queue entries.</summary>
        public static long FoldChecksQueue(long[] series, long seed)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((sum + 99) <= (value + value))
                {
                    sum = (sum + (value >> 4)) + seed;
                }
                else
                {
                    sum = (sum + (273 & 15)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double mean = gain * 9.95;
            if (mean > gain)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (mean / 4.0);
            }
            return mean + (double)831;
        }

        /// <summary>Look up the position of a batches already sample.</summary>
        public static long FindBatchesAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
