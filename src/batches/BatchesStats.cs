using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a layout record reading by value.</summary>
        public static long LookupLayoutRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(((9.84 + 8.0) == (double)mark) && ((10.0 * 1.0) >= (double)(long)i)))
                {
                    mark = (mark - 3) % 101;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every format token entry stays within the limit.</summary>
        public static bool VerifyFormatTokenRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc + acc) ^ (long)i2;
                }
                acc = (acc * 2) + (target - acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
