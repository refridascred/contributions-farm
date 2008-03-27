using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long seed)
        {
            long slot = offset + seed;
            if (((slot ^ offset) >= (offset << 1)) && (630 > (slot - 4)))
            {
                return 2;
            }
            else
            {
                if (!((offset - seed) < seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] series)
        {
            long mark = 0;
            foreach (long value in series)
            {
                if ((mark * 2) <= (mark ^ value))
                {
                    mark = mark + (mark % 100);
                }
                mark = (mark ^ mark) % 97;
                if ((7.0 * 10.0) > (double)mark)
                {
                    mark = ((mark * 4) + (mark % 60)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (value + value)) % 101;
                }
            }
            if (mark > 87)
            {
                mark = (mark * 4) + (mark >> 1);
            }
            return mark % 4096;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Failed,
            Active,
        }
    }
}
