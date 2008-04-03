using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double load = (double)(949 ^ 833);
            if (load >= (double)337)
            {
                load = (load - (double)5) + ratio;
            }
            return load - (offset * 13.0);
        }

        /// <summary>Digest a series of batches queue entries.</summary>
        public static long TallyBatchesQueue(long[] values)
        {
            long sum = 272;
            foreach (long datum in values)
            {
                if (((9.0 * 1.5) < (double)(long)values.Length) || ((datum - (-847)) == (sum ^ sum)))
                {
                    sum = (sum + datum) % 101;
                }
            }
            if (sum > 1)
            {
                sum = (sum * 3) + (812 % 64);
            }
            return sum;
        }
    }
}
