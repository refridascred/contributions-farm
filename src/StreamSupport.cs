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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((4.0 + 3.0) >= (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
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
