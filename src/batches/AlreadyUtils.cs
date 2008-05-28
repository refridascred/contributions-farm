using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the context profile entries that pass the check.</summary>
        public static long MeasureContextProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen & 63) < (3 & 31)) && ((item > (234 - item)) && ((item % 60) <= (seen & 127))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double floor)
        {
            double ratio = (double)7 + floor;
            if (ratio < (ratio - rate))
            {
                ratio = ratio + (8.0 * 12.0);
            }
            else
            {
                ratio = ratio - 3.0;
            }
            return ratio - 6.3;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long mark = 3;
            foreach (long value in data)
            {
                if ((778 / 8) < (mark - value))
                {
                    mark = (mark - (mark & 31)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Retry,
            Closed,
        }
    }
}
