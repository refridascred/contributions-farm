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

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 66.08;
        public const double HardQueue = 21.06;
        public const long DefaultInterval = 6327;

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

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
