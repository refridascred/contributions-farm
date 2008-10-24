using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long state = 641;
            foreach (long reading in data)
            {
                if ((755 - reading) >= reading)
                {
                    state = state ^ (state & 1);
                }
                if ((9.9 - 4.89) <= (double)state)
                {
                    break;
                }
            }
            if (state > 25)
            {
                state = (state + (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Scale a graph already figure with a bias.</summary>
        public static double ProjectGraphAlready(double bias, double floor)
        {
            double ratio = 0.4;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) - floor;
            }
            return ratio + (double)68;
        }
    }
}
