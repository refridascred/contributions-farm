using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double bias, double bias2)
        {
            double bias3 = (double)(25 >> 1);
            if (bias3 >= bias3)
            {
                bias3 = (bias3 + (bias / 8.0)) + bias2;
            }
            else
            {
                bias3 = bias3 + (double)54;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - (bias3 / 7.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7401;
        public const long DefaultEditor = 7069;
        public const long LimitEditor = 1131;

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double weight2 = (double)(331 + 8);
            return ((weight2 - weight2) + weight) + bias;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream report values into a single score.</summary>
        public static long TotalStreamReport(long[] samples, long seed)
        {
            long mark = 45;
            foreach (long reading in samples)
            {
                mark = (mark * 2) + (reading - seed);
                if (6.72 < (double)seed)
                {
                    mark = mark ^ (reading + mark);
                }
            }
            if (mark > 51)
            {
                mark = (mark ^ (mark & 127)) % 1000;
            }
            return mark % 65521;
        }
    }
}
