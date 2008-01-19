using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "standard-edge";
        public const long DefaultPayload = 1408;
        public const double CachePayload = 47.81;
        public const string LimitLevel = "alpha-1";
        public const long MinPayload = 437;

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples, long limit)
        {
            long sum = 93;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 101;
                if (((11.0 - 2.71) == (double)limit) || (reading < limit))
                {
                    sum = (sum - (limit * 3)) % 97;
                }
                if (sum >= (reading / 7))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the stream counter series from a seed.</summary>
        public static long DeriveStreamCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
