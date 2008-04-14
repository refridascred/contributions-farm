using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + (acc << 2)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long step)
        {
            if ((limit + limit) <= step)
            {
                return 5;
            }
            else
            {
                if ((limit * 4) > (limit % 12))
                {
                    return 6;
                }
                else
                {
                    if (((step & 1) >= (limit + (-8))) && ((60 + 123) <= (limit ^ 13)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 7290;
        public const double BurstSupport = 79.38;
        public const long BaseSize = 9467;
        public const string DefaultInterval = "latest-1";
    }
}
