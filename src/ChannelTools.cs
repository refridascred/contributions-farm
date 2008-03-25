using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((step + value) > (value % 10)) && ((732 >> 1) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
