using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitDepth = 84.25;
        public const long StepContributi = 8160;
        public const long BaseFactor = 8200;
        public const string MaxContributi = "standard-edge";
        public const string IdleLevel = "fallback-1";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)bound >= (20.0 + 19.0)))
                {
                    mix = ((mix * 2) + ((long)i + bound)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((0.71 * 6.76) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + bound) < floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
