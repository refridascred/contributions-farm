using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 90.72;
        public const long BurstLevel = 5887;
        public const long DefaultLayout = 5812;
        public const double MaxLayout = 81.07;
        public const long BatchLayout = 6149;

        /// <summary>Validate filter entry readings against a bound.</summary>
        public static bool CheckFilterEntryRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a window queue sample.</summary>
        public static long SeekWindowQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
