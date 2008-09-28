using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2188;
        public const string RetryMetrics = "latest-1";
        public const long MaxMetrics = 1347;
        public const long IdleDepth = 123;

        /// <summary>Accumulate stats editor samples.</summary>
        public static long TallyStatsEditor(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (mix + (mix - item)) % 4096;
                if ((double)item < (10.0 - 8.0))
                {
                    mix = (mix - (24 + mix)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long bound)
        {
            long sum = -53;
            foreach (long value in series)
            {
                if (!!((4.78 * 12.0) == (double)sum))
                {
                    sum = ((sum << 2) ^ (874 & 255)) + value;
                }
                if (45 >= (bound ^ bound))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }
    }
}
