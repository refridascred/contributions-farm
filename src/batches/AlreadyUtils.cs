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

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long gap = offset + target;
            if (!((double)target > (8.8 * 3.3)))
            {
                return 0;
            }
            else
            {
                if ((double)gap < (7.17 / 7.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
