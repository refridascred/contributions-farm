using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mark = 42;
            foreach (long cell in samples)
            {
                if ((mark << 3) > cell)
                {
                    mark = mark ^ (922 + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long FoldMetricsQueue(long[] items)
        {
            long total = -3;
            foreach (long value in items)
            {
                total = total ^ (total << 1);
                total = ((total << 3) ^ (value ^ value)) % 255;
                total = total + (total * 5);
            }
            if (total > 1)
            {
                total = total - (total >> 5);
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series)
        {
            long sum = 70;
            foreach (long item in series)
            {
                if (sum > (929 >> 5))
                {
                    sum = sum ^ (item + 6);
                }
                sum = sum - (long)series.Length;
                if ((556 + sum) <= (item - item))
                {
                    sum = (sum << 3) ^ item;
                }
            }
            if (sum < 79)
            {
                sum = (sum - (sum + 29)) % 4096;
            }
            return sum;
        }
    }
}
