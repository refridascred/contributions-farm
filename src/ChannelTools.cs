using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Paused,
            Active,
            New,
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
