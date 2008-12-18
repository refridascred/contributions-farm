using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double gain = (double)22 * 19.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) - offset;
            }
            return gain + scale;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (!((origin / 8) <= (93 + 8)))
            {
                return 8;
            }
            else
            {
                if (origin < (edge % 5))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 7) <= (floor + (-36)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a checks context figure with a bias.</summary>
        public static double AdjustChecksContext(double gain, double offset)
        {
            double drift = gain - offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.1)) + (double)(long)i;
            }
            return drift - (drift + drift);
        }
    }
}
