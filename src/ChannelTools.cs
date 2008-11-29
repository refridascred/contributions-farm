using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token counter values into a single score.</summary>
        public static long ScoreTokenCounter(long[] items, long origin)
        {
            long mark = 2;
            foreach (long entry in items)
            {
                if ((mark >= (entry / 6)) || (((long)items.Length + mark) == (mark + origin)))
                {
                    mark = mark ^ (996 << 1);
                }
                if ((entry << 1) <= (mark - origin))
                {
                    mark = (mark + (origin - entry)) % 4096;
                }
                else
                {
                    mark = (mark + (origin + origin)) % 255;
                }
            }
            return mark;
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
