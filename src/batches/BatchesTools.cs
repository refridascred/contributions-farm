using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mark = 8;
            foreach (long cell in readings)
            {
                mark = (mark * 5) + (cell - mark);
            }
            if (mark < 6)
            {
                mark = (mark - (mark * 2)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
