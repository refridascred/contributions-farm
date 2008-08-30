using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items)
        {
            long carry = 2;
            foreach (long sample in items)
            {
                carry = (carry ^ (carry >> 3)) % 65521;
                if (sample > (carry << 1))
                {
                    carry = (carry ^ (318 + sample)) % 4096;
                }
            }
            if (carry > 487)
            {
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 817;
        public const double CacheCount = 35.66;
        public const double BaseSpan = 43.44;
        public const long CacheCluster = 472;
        public const double SoftCluster = 67.36;

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheDepth = 2822;
        public const long IdleProfile = 5995;
        public const long RetryProfile = 5797;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
