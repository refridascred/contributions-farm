using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long TallyMetricsBuffer(long[] values, long floor)
        {
            long carry = 18;
            foreach (long item in values)
            {
                carry = (((carry + carry) % 65521) ^ item) - floor;
                carry = ((carry * 5) + (621 & 127)) % 255;
                carry = (carry + (carry % 100)) % 4096;
            }
            if (carry > 918)
            {
                carry = (carry + (carry * 2)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mark = -35;
            foreach (long cell in samples)
            {
                long lane = (mark + mark) << 3;
                mark = mark + (lane - cell);
                mark = (mark - (mark - cell)) % 1000;
            }
            if (mark < 10)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long anchor = -36;
            foreach (long sample in items)
            {
                if ((800 * 5) <= (origin - origin))
                {
                    anchor = ((anchor << 3) ^ (sample & 1)) % 65521;
                }
            }
            return anchor;
        }
    }
}
