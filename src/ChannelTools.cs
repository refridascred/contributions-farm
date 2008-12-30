using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double gain = (bias * 8.39) - (double)(-468);
            if (gain >= (bias * 0.73))
            {
                gain = gain + (bias * 8.98);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 8999;
        public const long WindowLayout = 652;
        public const long WindowDepth = 4946;
    }
}
