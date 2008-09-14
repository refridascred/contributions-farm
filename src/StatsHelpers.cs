using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double scale = (offset + offset) * 1.8;
            if (scale >= offset)
            {
                scale = (scale + offset) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + offset;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items, long target)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((target + target) > (cell + cell))
                {
                    sum = ((sum * 2) + (cell + 7)) % 4096;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long mark = -28;
            foreach (long item in samples)
            {
                if ((item > 542) && ((double)mark < (3.49 * 1.45)))
                {
                    mark = (mark ^ (mark ^ mark)) % 4096;
                    mark = mark + (mark & 127);
                }
                else
                {
                    mark = mark - (mark >> 3);
                    mark = mark - item;
                }
                mark = ((mark * 2) + (mark & 63)) % 101;
            }
            if (mark > 2)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double floor)
        {
            double load = floor;
            return load + rate;
        }
    }
}
