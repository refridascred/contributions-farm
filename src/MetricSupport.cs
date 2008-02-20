using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double bias2)
        {
            double gain = (double)423;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + bias2;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples, long origin)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if (((long)samples.Length % 5) > (0 ^ total))
                {
                    total = total ^ (97 - 68);
                }
                if (((double)72 > (double)sample) && ((long)samples.Length < origin))
                {
                    total = (total << 2) ^ (total - 661);
                }
            }
            return total % 97;
        }
    }
}
