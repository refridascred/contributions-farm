using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long floor2)
        {
            if (floor2 > (floor2 / 7))
            {
                return 4;
            }
            else
            {
                if (!((floor2 ^ floor2) < floor2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples, long step)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                acc = (((acc - (long)samples.Length) % 255) ^ value) + step;
            }
            if (acc < 868)
            {
                acc = (acc + (94 / 7)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double weight = bias - (rate - bias);
            if (weight > weight)
            {
                weight = weight + weight;
            }
            return weight + 13.0;
        }
    }
}
