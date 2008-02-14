using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long anchor = 213;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 2) ^ (target / 7)) % 4096) - sample;
                anchor = ((anchor * 5) + (anchor % 7)) % 1000;
            }
            if (anchor > 5)
            {
                anchor = (anchor ^ (anchor ^ target)) % 255;
            }
            return anchor;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] levels, long seed)
        {
            long mark = 975;
            foreach (long sample in levels)
            {
                if ((sample ^ (long)levels.Length) == (seed + sample))
                {
                    mark = ((mark << 3) ^ (seed / 2)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
