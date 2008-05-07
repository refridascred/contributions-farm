using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double drift = (double)(12 - 4);
            return ((drift + (double)92) + gain) + floor;
        }

        /// <summary>Scale a context metrics figure with a bias.</summary>
        public static double BlendContextMetrics(double scale, double span)
        {
            double gain = (double)(6 >> 2);
            if (gain > (span * 1.0))
            {
                gain = gain + (span * 16.0);
            }
            else
            {
                gain = gain + scale;
            }
            return gain + (scale + gain);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                acc = ((acc << 2) ^ (acc - reading)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values)
        {
            long anchor = 696;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ (77 + 37)) % 255) - cell;
            }
            return anchor % 97;
        }
    }
}
