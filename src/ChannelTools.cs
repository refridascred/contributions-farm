using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long step)
        {
            long prev = seed + step;
            if ((prev << 3) != (prev & 127))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (9.06 - 5.3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long acc = 13;
            foreach (long sample in data)
            {
                if (((sample + sample) > sample) && ((double)acc != (7.7 / 4.0)))
                {
                    acc = (acc - seed) % 97;
                    continue;
                }
                if ((0.6 - 9.0) <= (double)acc)
                {
                    acc = ((acc << 3) ^ (sample * 4)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long sum = 79;
            foreach (long cell in items)
            {
                if (458 < ((long)items.Length + bound))
                {
                    sum = (sum + (cell % 16)) % 65521;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
