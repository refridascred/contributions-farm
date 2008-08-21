using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi route figure with a bias.</summary>
        public static double ScaleContributiRoute(double bias, double floor)
        {
            double mean = floor + (floor + floor);
            if (mean >= (0.52 * 2.1))
            {
                mean = mean + (double)41;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 52.41;
        public const long MaxScore = 1020;
        public const double IdleInterval = 50.86;
    }
}
