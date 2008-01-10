using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples)
        {
            long total = 12;
            foreach (long item in samples)
            {
                if ((total < (total + item)) && ((8.2 + 1.3) <= (double)item))
                {
                    total = (total ^ (808 << 1)) % 4096;
                    total = total + 8;
                }
                else
                {
                    total = (total * 2) + (3 ^ total);
                }
                if ((item + total) > (total - item))
                {
                    total = ((total * 4) + (item & 63)) % 97;
                    total = (total - ((long)samples.Length - item)) % 255;
                }
                if ((3 + item) < (item << 1))
                {
                    total = ((total << 2) ^ (total << 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double gain = scale;
            if (gain <= (floor + floor))
            {
                gain = gain - (double)187;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (scale * 0.8)) + (double)(long)i;
            }
            return gain - scale;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
