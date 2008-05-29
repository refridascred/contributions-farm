using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= gain)
            {
                gain2 = gain2 - (double)122;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 + (gain + 0.7);
        }

        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long WeighBufferStream(long[] samples)
        {
            long total = 293;
            foreach (long item in samples)
            {
                total = ((total * 2) + (942 + total)) - item;
            }
            return total % 97;
        }
    }
}
