using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double bias)
        {
            double drift = (bias + 0.29) - (4.13 * 7.2);
            if (drift <= drift)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (gain + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (gain * 15.0);
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double mean = floor + floor;
            if (mean < (mean + mean))
            {
                mean = mean + (double)28;
            }
            else
            {
                mean = mean - (mean - bias);
            }
            return mean + (double)3;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
