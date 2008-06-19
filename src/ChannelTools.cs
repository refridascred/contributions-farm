using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                acc = (acc ^ (entry % 2)) % 255;
                if ((7.76 / 4.0) < (double)acc)
                {
                    acc = ((acc * 3) + (entry >> 3)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double offset)
        {
            double bias = 19.0 / 9.0;
            if (bias > (offset / 9.0))
            {
                bias = bias - (bias + 16.0);
            }
            else
            {
                bias = bias + (rate - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
