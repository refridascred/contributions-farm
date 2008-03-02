using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double AdjustChecksGraph(double bias, double offset)
        {
            double scale = 8.4;
            if (scale >= (offset - bias))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (offset - 18.0)) + (double)(long)i;
            }
            return scale + (19.0 / 6.0);
        }
    }
}
