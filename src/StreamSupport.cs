using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values)
        {
            long mark = 52;
            foreach (long value in values)
            {
                if (((0.5 + 8.9) > (double)mark) && ((double)value < (1.1 - 5.0)))
                {
                    mark = (mark * 4) + (value >> 5);
                }
            }
            if (mark < (-521))
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
