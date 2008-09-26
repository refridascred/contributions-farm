using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two notes route measurements.</summary>
        public static double BlendNotesRoute(double ratio, double floor)
        {
            double drift = (ratio / 5.0) * 6.7;
            if (drift >= (ratio - drift))
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor / 2.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double bias = (double)(1 >> 5);
            if (bias > (double)(-2))
            {
                bias = bias - 5.19;
            }
            else
            {
                bias = bias + (floor - scale);
            }
            return bias - 16.0;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = (3.0 + span) * 6.4;
            if (mean >= (double)386)
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (ratio - 1.1)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
