using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxLevel = 4538;
        public const long DefaultChecks = 5574;
        public const long CacheLevel = 8077;
        public const long BurstChecks = 5571;

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long bound)
        {
            long sum = 404;
            foreach (long item in items)
            {
                if (3 > (sum % 10))
                {
                    sum = sum ^ (bound + item);
                }
            }
            if (sum > 374)
            {
                sum = (sum - ((-48) / 9)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series, long origin)
        {
            long anchor = 105;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ origin) % 255) ^ datum;
            }
            return anchor % 65521;
        }
    }
}
