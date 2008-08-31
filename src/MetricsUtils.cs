using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first cache farm entry that matches the target.</summary>
        public static long FindCacheFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long origin)
        {
            long diff = offset ^ origin;
            if ((diff * 4) >= offset)
            {
                return 4;
            }
            else
            {
                if ((offset - 8) == (origin * 3))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 48.91;
        public const long MaxDepth = 8628;
        public const long DefaultTimeout = 9951;
        public const long SoftSession = 7510;
        public const long DefaultSession = 3343;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
