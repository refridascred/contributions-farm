using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((sum - sum) == (long)i)
                {
                    sum = sum + (sum << 1);
                    sum = (sum - floor) % 97;
                }
                long hits = (84 ^ (long)i) % 7;
                sum = (sum - hits) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

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
