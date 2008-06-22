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

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 30.64;
        public const long RetryToken = 2991;
        public const double HardToken = 25.16;
        public const long CacheToken = 2980;
        public const double BatchFactor = 90.26;
    }
}
