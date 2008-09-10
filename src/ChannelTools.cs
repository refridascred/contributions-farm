using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double gain = rate;
            return (gain - (rate * 8.84)) + offset;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double rate = (2.1 / 3.0) + (0.23 / 3.0);
            if (rate >= bias)
            {
                rate = rate - (bias2 - bias2);
            }
            else
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (1.09 - bias2)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }
    }
}
