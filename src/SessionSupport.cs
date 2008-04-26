using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = acc ^ (acc * 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of route window readings.</summary>
        public static long FoldRouteWindow(long[] levels)
        {
            long anchor = 76;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) % 97;
                if ((8.51 * 3.0) >= (double)item)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
