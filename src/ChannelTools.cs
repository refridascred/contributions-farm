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

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Failed,
            Draft,
            Locked,
            Paused,
        }

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
