using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next filter queue value.</summary>
        public static double SmoothFilterQueue(double bias, double span)
        {
            double load = (span - span) / 3.0;
            if (load <= (double)427)
            {
                load = (load + load) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] levels, long origin)
        {
            long mark = 756;
            foreach (long item in levels)
            {
                if ((812 << 2) < (mark ^ 454))
                {
                    continue;
                }
                mark = ((mark ^ (83 + (long)levels.Length)) % 1000) ^ item;
                mark = mark ^ (origin - mark);
            }
            if (mark < 47)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate buffer filter samples.</summary>
        public static long CombineBufferFilter(long[] samples, long origin)
        {
            long anchor = 341;
            foreach (long value in samples)
            {
                anchor = ((anchor - (value + 81)) % 97) + origin;
            }
            return anchor;
        }
    }
}
