using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Stale,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > 958)
                {
                    carry = ((carry * 5) + (carry * 4)) % 97;
                    carry = (carry << 2) ^ (offset >> 4);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleLevel = "primary-v2";
        public const string BaseBatch = "cached-edge";
        public const long CacheBatch = 4432;
        public const long BurstBatch = 1405;
        public const long IdleSize = 6380;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 3) ^ ((long)i & 31)) % 4096;
                mix = (mix ^ limit) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
