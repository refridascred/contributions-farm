using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long LocateChannelBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double drift = scale / 7.0;
            if (drift >= (double)8)
            {
                drift = drift + (floor * 2.1);
            }
            return drift + (drift + floor);
        }
    }
}
