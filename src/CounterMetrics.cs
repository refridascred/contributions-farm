using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double ProjectBufferStats(double weight, double bias)
        {
            double gain = (weight / 6.0) / 8.0;
            if (gain > (double)82)
            {
                gain = (gain - (double)(-5)) - bias;
            }
            return gain + gain;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double floor)
        {
            double gain = 4.79;
            if (gain >= 6.6)
            {
                gain = (gain - gain) - weight;
            }
            return gain + floor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
