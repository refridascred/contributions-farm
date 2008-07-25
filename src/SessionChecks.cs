using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (ratio + ratio))
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)213;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings, long step)
        {
            long mix = 368;
            foreach (long cell in readings)
            {
                if ((251 & 31) > (step % 3))
                {
                    mix = (((mix * 3) + 64) % 65521) + cell;
                }
            }
            return mix;
        }
    }
}
