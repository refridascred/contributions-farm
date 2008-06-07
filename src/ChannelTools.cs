using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (target >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster entry readings against a bound.</summary>
        public static bool GuardClusterEntryRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
