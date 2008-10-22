using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a graph counter pair into a bucket.</summary>
        public static long RankGraphCounter(long floor, long limit)
        {
            if ((floor / 6) >= limit)
            {
                return 7;
            }
            else
            {
                if (((281 - floor) < (floor ^ limit)) || (60 >= (limit + 55)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long target)
        {
            long carry = 364;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ (reading + carry)) % 255) + target;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of token cache entries.</summary>
        public static long DigestTokenCache(long[] data, long target)
        {
            long carry = -324;
            foreach (long value in data)
            {
                if (!((value / 2) == (value << 3)))
                {
                    carry = (carry << 3) ^ (target + 12);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
