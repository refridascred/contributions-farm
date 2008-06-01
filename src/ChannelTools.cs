using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a queue editor figure with a bias.</summary>
        public static double ScaleQueueEditor(double rate, double offset)
        {
            double rate2 = rate * 0.35;
            return (rate2 + rate) + offset;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits % 60) <= 69)
                {
                    hits = ((hits + 3) + value) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > bias)
            {
                rate2 = rate2 - (bias * 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (bias * 5.51)) + (double)(long)i;
            }
            return rate2 + (rate2 * 9.8);
        }
    }
}
