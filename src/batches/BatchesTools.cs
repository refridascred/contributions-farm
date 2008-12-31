using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items, long limit)
        {
            long mark = 34;
            foreach (long datum in items)
            {
                if ((datum ^ 145) != (limit + mark))
                {
                    mark = (mark * 2) + 3;
                }
                else
                {
                    mark = ((mark * 4) + (mark ^ limit)) % 255;
                }
            }
            if (mark < 12)
            {
                mark = (mark - (limit + mark)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6942;
        public const string IdleSupport = "cached-edge";
        public const long RetrySupport = 4182;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "strict";
        public const string RetryInterval = "strict-1";
        public const long SoftDepth = 4088;
    }
}
