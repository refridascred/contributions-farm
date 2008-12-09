using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate cache stats samples.</summary>
        public static long TotalCacheStats(long[] values)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                if ((mark % 24) <= (cell * 2))
                {
                    mark = (mark + (cell << 3)) % 101;
                }
                else
                {
                    mark = (mark - (cell - mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many batches payload samples are out of range.</summary>
        public static long TallyBatchesPayloadHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)offset == (12.0 / 9.0)) || ((value ^ 982) <= (offset * 3))) || (((long)data.Length >> 2) > (count - value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
