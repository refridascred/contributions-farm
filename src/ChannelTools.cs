using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4910;
        public const long SoftBatch = 6323;
        public const string BatchSpan = "open-edge";
        public const string MinBatch = "cached";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((146 - 287) < (658 - datum))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
