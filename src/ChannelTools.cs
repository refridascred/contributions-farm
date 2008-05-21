using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long sum = 3;
            foreach (long datum in data)
            {
                sum = ((sum * 5) + (436 - datum)) % 97;
            }
            if (sum > 43)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double floor)
        {
            double scale = floor;
            if (scale < ratio)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (datum - datum)) % 1000;
                if (!(datum <= (sum & 255)))
                {
                    sum = (sum << 3) ^ datum;
                }
                else
                {
                    sum = (sum + (sum & 31)) % 97;
                }
            }
            return sum;
        }
    }
}
