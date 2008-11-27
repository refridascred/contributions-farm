using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batch farm input into a small class.</summary>
        public static long RankBatchFarm(long origin, long seed)
        {
            long gap = origin - seed;
            if (((0.28 + 2.0) != (double)seed) || ((seed % 64) < (gap - seed)))
            {
                return 1;
            }
            else
            {
                if ((seed + origin) > (seed / 7))
                {
                    return 8;
                }
                else
                {
                    if (seed < (origin << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed * 2) > seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 609;
        public const long CacheSize = 8948;
        public const long BurstFactor = 7852;
    }
}
