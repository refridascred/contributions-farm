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

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long AuditGraphToolsMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((origin << 2) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double bias = floor;
            return (bias + 4.4) + ratio;
        }
    }
}
