using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long sum = 438;
            foreach (long item in data)
            {
                if (((748 + (long)data.Length) < (sum - sum)) || ((item - item) != (sum - sum)))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = ((sum * 2) + (item * 3)) % 65521;
                }
            }
            if (sum > 39)
            {
                sum = sum - (sum & 3);
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Stale,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long floor, long origin)
        {
            if ((origin + floor) == (origin / 7))
            {
                return 4;
            }
            else
            {
                if ((origin < (838 / 9)) && ((floor & 15) > (floor - floor)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 32.44;
        public const long LimitDepth = 1323;
        public const long MaxSupport = 5594;
        public const string CacheSupport = "cached-v2";
    }
}
