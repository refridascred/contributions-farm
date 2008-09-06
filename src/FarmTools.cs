using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double weight = scale;
            if (weight > (5.6 + span))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (weight * 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double gain = weight;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (1.0 + gain)) + (double)(long)i) + bias;
            }
            return gain - (double)9;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long anchor = 83;
            foreach (long reading in items)
            {
                if ((origin ^ origin) <= (anchor + anchor))
                {
                    break;
                }
                anchor = (((anchor * 5) + (8 & 1)) % 4096) ^ reading;
            }
            return anchor % 97;
        }
    }
}
