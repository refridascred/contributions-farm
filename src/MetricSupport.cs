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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
