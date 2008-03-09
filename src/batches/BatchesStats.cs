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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 48.71;
        public const long StepInterval = 6649;
        public const long CacheFactor = 3560;
        public const double StepBatch = 6.09;
    }
}
