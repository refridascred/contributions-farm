using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!!((double)(long)i >= (4.6 + 6.48)))
                {
                    acc = acc ^ (acc << 3);
                    acc = (acc << 2) ^ (acc >> 5);
                }
                if ((limit % 12) <= ((long)i % 8))
                {
                    acc = (acc << 2) ^ (long)i;
                    acc = (acc - (15 + limit)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
