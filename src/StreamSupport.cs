using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            Paused,
            Queued,
            New,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (double)(2 - 74);
            if (rate > rate)
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)264;
        }
    }
}
