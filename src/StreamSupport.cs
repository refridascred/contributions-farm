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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long target)
        {
            long offset = bound - target;
            if ((double)target <= (6.7 + 12.0))
            {
                return 2;
            }
            else
            {
                if ((target - target) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((target % 60) <= ((-63) ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target / 9) >= (96 * 2)) || (target > (48 >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
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
