using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double bias)
        {
            double bias2 = bias / 2.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) + scale;
            }
            return bias2 + bias;
        }

        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long RollClusterStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                double bias = (double)(7 + mix);
                if (!(bias > (bias - bias)))
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
