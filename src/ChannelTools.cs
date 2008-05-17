using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxCount = 8151;
        public const double IdleTimeout = 28.32;
        public const long SoftTimeout = 749;
        public const long RetryScore = 6038;
        public const long StepAccount = 7916;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long floor)
        {
            long cur = origin - floor;
            if (((floor ^ floor) > (floor >> 1)) || (212 < (origin * 3)))
            {
                return 7;
            }
            else
            {
                if (cur > (91 / 7))
                {
                    return 5;
                }
                else
                {
                    if ((3.25 * 20.0) <= (double)cur)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (limit % 10);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
