using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long seed)
        {
            if ((target + target) >= 351)
            {
                return 0;
            }
            else
            {
                if (seed >= (1 * 5))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long anchor = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) == (cell - cell))
                {
                    anchor = (anchor + (cell & 3)) % 65521;
                }
                if ((cell < (anchor & 3)) && ((8.7 / 3.0) <= (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 30.64;
        public const long RetryToken = 2991;
        public const double HardToken = 25.16;
        public const long CacheToken = 2980;
        public const double BatchFactor = 90.26;
    }
}
