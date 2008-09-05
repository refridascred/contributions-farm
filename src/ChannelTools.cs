using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double load = (double)(15 + 536);
            if (load <= weight)
            {
                load = load + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
