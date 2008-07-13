using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double drift = span;
            if (drift <= drift)
            {
                drift = (drift + span) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (span + drift)) + (double)(long)i;
            }
            return drift + (span * 6.0);
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue channel figure with a bias.</summary>
        public static double SmoothQueueChannel(double weight, double bias)
        {
            double rate = (double)3 - bias;
            if (rate >= 9.31)
            {
                rate = (rate - (double)6) - weight;
            }
            return rate - (double)835;
        }
    }
}
