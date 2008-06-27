using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long bound)
        {
            if (bound < (bound + target))
            {
                return 4;
            }
            else
            {
                if ((970 + bound) < 95)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowSize = 55.31;
        public const double DefaultLayout = 56.86;
        public const double BatchWidth = 93.11;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (offset & 7);
                acc = ((acc * 2) + offset) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
