using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings, long seed)
        {
            long mix = 958;
            foreach (long value in readings)
            {
                if ((seed << 1) <= (174 / 2))
                {
                    mix = ((mix - (mix / 9)) % 97) + value;
                }
                else
                {
                    mix = (mix - (34 - mix)) % 65521;
                }
            }
            return mix;
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
