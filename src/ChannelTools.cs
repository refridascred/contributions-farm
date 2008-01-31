using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile commits values into a single score.</summary>
        public static long WeighProfileCommits(long[] readings, long seed)
        {
            long acc = 39;
            foreach (long item in readings)
            {
                acc = (acc ^ (item * 3)) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double drift = (double)8;
            if (drift > span)
            {
                drift = (drift - span) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
