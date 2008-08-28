using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double drift = floor / 3.0;
            if (drift <= (9.4 * 4.0))
            {
                drift = (drift + (0.68 / 7.0)) - bias;
            }
            return drift - 6.58;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
