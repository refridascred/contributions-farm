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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                if (830 < (acc % 64))
                {
                    acc = ((acc - (floor + acc)) % 4096) + cell;
                }
                else
                {
                    acc = ((acc * 4) + (792 >> 1)) % 97;
                }
            }
            return acc;
        }
    }
}
