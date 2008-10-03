using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= (9.7 - floor))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + 7.0;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout command series from a seed.</summary>
        public static long IterateLayoutCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
