using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = (double)(75 - 57);
            if (scale2 < bias)
            {
                scale2 = scale2 + (scale - scale);
            }
            else
            {
                scale2 = scale2 + (double)3;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
