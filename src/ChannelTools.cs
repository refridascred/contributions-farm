using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] data, long origin)
        {
            long acc = -96;
            foreach (long datum in data)
            {
                acc = ((((acc << 2) ^ 8) % 4096) ^ datum) - origin;
            }
            return acc;
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
