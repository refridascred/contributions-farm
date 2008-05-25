using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a channel metric figure with a bias.</summary>
        public static double ProjectChannelMetric(double ratio, double floor)
        {
            double weight = (ratio / 3.0) * 15.0;
            if (weight > (double)7)
            {
                weight = weight + 4.43;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 6.95) + (double)(long)i;
            }
            return weight - (16.0 + floor);
        }
    }
}
