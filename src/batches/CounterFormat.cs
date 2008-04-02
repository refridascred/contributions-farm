using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long mark = 951;
            foreach (long cell in items)
            {
                long matches = (mark + mark) + ((long)items.Length * 5);
                if ((matches ^ cell) >= ((long)items.Length + mark))
                {
                    break;
                }
                if (!((double)mark <= (9.0 + 7.9)))
                {
                    mark = (mark - (mark << 1)) % 255;
                }
                else
                {
                    mark = ((mark * 3) + 847) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((1.8 - 7.0) <= (double)count)
                {
                    count = ((count + 2) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }
    }
}
