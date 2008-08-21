using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target * 3) < (reading / 5)) && (target < (hits << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double rate = (double)(4 / 3);
            if (rate >= (weight - rate))
            {
                rate = rate + (bias / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
