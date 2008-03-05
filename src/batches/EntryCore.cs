using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long offset)
        {
            if (((seed + seed) != (984 - offset)) || ((4.77 * 6.0) == (double)offset))
            {
                return 5;
            }
            else
            {
                if ((offset < (offset - 9)) && ((seed - offset) != (8 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 7) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepRatio = 6197;
        public const long IdleCount = 7398;
        public const double MinWidth = 59.1;
        public const double LimitFactor = 69.15;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
