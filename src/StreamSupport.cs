using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine batches order values into a single score.</summary>
        public static long TallyBatchesOrder(long[] series)
        {
            long mark = 23;
            foreach (long reading in series)
            {
                if ((3.0 <= (double)mark) || ((reading - 313) < (949 - 60)))
                {
                    mark = ((mark * 3) + reading) % 1000;
                }
            }
            if (mark > 3)
            {
                mark = ((mark * 4) + (long)series.Length) % 255;
            }
            return mark;
        }

        /// <summary>Count route cache pairs that satisfy a relation.</summary>
        public static long MatchRouteCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate queue support readings against a bound.</summary>
        public static bool ValidateQueueSupportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
