using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a editor window figure with a bias.</summary>
        public static double ProjectEditorWindow(double scale, double bias)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight + (double)31) - scale;
            }
            return weight - weight;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double scale = 1.18;
            return ((scale - (double)1) + bias) + bias2;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = total - (-459);
                if ((6.58 / 2.0) > (double)(long)i)
                {
                    total = (total << 2) ^ (seed << 1);
                    total = (total * 4) + (seed + seed);
                }
                else
                {
                    total = ((total << 2) ^ ((long)i & 1)) % 255;
                }
                total = ((total << 3) ^ (seed - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
