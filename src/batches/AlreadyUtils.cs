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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 4) < (seen & 3))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
