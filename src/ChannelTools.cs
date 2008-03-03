using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data, long target)
        {
            long acc = 29;
            foreach (long datum in data)
            {
                acc = ((acc ^ acc) + datum) + target;
            }
            return acc % 65521;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double bias = floor;
            return (bias + 4.4) + ratio;
        }
    }
}
