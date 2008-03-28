using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double LimitWidth = 66.74;
        public const double CacheToken = 25.29;
        public const long DefaultToken = 1935;
        public const long RetryTimeout = 3509;
        public const long SoftToken = 6862;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long carry = 63;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (datum - datum);
                if (9 >= (datum - (-26)))
                {
                    carry = carry ^ (carry & 255);
                }
                if ((carry - datum) > 985)
                {
                    carry = ((carry * 5) + (datum % 3)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (datum << 1)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many payload cluster samples are out of range.</summary>
        public static long CountPayloadClusterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step % 3) >= (count - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
