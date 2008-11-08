using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double scale = (ratio / 4.0) + (double)632;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Locked,
            Draft,
        }
    }
}
