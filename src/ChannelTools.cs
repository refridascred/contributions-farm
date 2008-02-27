using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route filter measurements.</summary>
        public static double ScaleRouteFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain + (double)3) - floor;
            }
            return gain + (weight / 7.0);
        }
    }
}
