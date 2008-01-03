using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (limit ^ 0)) % 255;
                sum = ((sum << 3) ^ (limit - sum)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 1761;
        public const long IdleRatio = 1005;
        public const long IdleSupport = 1932;
        public const long MaxSupport = 4338;
        public const string MaxWidth = "latest-v2";
    }
}
