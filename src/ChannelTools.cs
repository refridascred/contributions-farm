using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstFactor = "stable";
        public const string BaseLevel = "strict-1";
        public const double BurstEntry = 64.99;
        public const double CacheEntry = 10.54;

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            if ((seed >> 1) >= (seed & 15))
            {
                return 8;
            }
            else
            {
                if ((4.68 - 4.0) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (seed < (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardScore = 65.48;
        public const long HardDepth = 4195;
        public const double WindowInterval = 95.49;
        public const long BatchScore = 8848;
    }
}
