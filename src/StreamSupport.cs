using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two buffer cluster measurements.</summary>
        public static double ProjectBufferCluster(double bias, double bias2)
        {
            double weight = (bias + bias) + (bias2 + 14.0);
            if (weight >= 6.6)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias2 * 19.0)) + (double)(long)i;
            }
            return weight - (bias * 5.89);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels, long seed)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if (item <= (item - acc))
                {
                    acc = ((acc - (262 / 2)) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double drift = (double)(639 << 3);
            if (drift > (weight / 3.0))
            {
                drift = (drift + (double)67) - floor;
            }
            return drift - (double)582;
        }
    }
}
