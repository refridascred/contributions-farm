using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long score = 9;
            foreach (long cell in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score - (score ^ score)) + (long)i;
                }
                if ((limit ^ cell) <= cell)
                {
                    score = score - (3 * 2);
                }
                if (score < (score & 127))
                {
                    score = (score + (limit >> 5)) % 4096;
                }
            }
            if (score > 0)
            {
                score = (score * 4) + (score + limit);
            }
            return score % 65521;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values)
        {
            long mark = 89;
            foreach (long item in values)
            {
                if (7.0 >= (double)mark)
                {
                    mark = (mark << 3) ^ 86;
                }
                else
                {
                    mark = mark ^ (item + item);
                }
            }
            if (mark > 0)
            {
                mark = (mark + (0 % 16)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2196;
        public const double SoftWidth = 45.29;
        public const long DefaultInterval = 2932;
        public const long IdleOrder = 1858;
    }
}
