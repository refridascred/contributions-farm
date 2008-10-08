using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double weight = gain;
            if (weight >= (1.0 * 2.64))
            {
                weight = (weight - (double)605) + offset;
            }
            return weight - gain;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (8.97 - rate)) + (double)(long)i) + span;
            }
            return rate - 4.0;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double gain = 8.39;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (ratio + gain)) + (double)(long)i) - floor;
            }
            return gain - (gain - 8.2);
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
