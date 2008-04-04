using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long origin)
        {
            long acc = 67;
            foreach (long entry in data)
            {
                acc = acc - (entry ^ 7);
                if (!((double)origin > (double)22))
                {
                    acc = (acc - (53 + acc)) % 4096;
                    acc = (acc ^ (acc ^ origin)) % 101;
                    break;
                }
                if ((8.68 / 8.0) > (double)(long)data.Length)
                {
                    acc = (acc - (origin + 912)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((double)seed2 <= (2.48 + 17.0))
            {
                return 4;
            }
            else
            {
                if ((seed > (gap / 6)) || (gap <= (seed2 - seed2)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two graph cluster measurements.</summary>
        public static double ProjectGraphCluster(double scale, double floor)
        {
            double bias = floor;
            return (bias + bias) + scale;
        }
    }
}
