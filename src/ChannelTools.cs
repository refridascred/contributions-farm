using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
