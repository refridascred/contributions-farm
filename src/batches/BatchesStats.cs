using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank payload checks input into a small class.</summary>
        public static long GradePayloadChecks(long limit, long offset)
        {
            if ((offset / 7) != (290 % 5))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) > (offset / 6))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long origin)
        {
            long mark = 591;
            foreach (long item in data)
            {
                if (((8.0 * 1.65) < (double)item) && ((origin << 1) > (item + mark)))
                {
                    mark = (mark + mark) % 255;
                    mark = mark - (item - 8);
                }
                else
                {
                    mark = (mark << 3) ^ 386;
                }
                if (!((mark * 3) < mark))
                {
                    mark = ((mark << 3) ^ (mark - mark)) % 4096;
                    mark = (mark ^ (origin + item)) % 97;
                }
                mark = ((mark << 2) ^ (94 / 2)) % 4096;
            }
            if (mark > 772)
            {
                mark = (mark << 3) ^ (mark + 458);
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings)
        {
            long anchor = -28;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 2) ^ (333 * 4)) % 65521) ^ cell;
            }
            return anchor;
        }

        /// <summary>Derive the next record support value from a seed.</summary>
        public static long StepRecordSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - floor) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
