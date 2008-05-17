using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "stable-v2";
        public const long BatchTimeout = 5429;
        public const long BaseFilter = 4688;
        public const long StepScore = 1267;

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
