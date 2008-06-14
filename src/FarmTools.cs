using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 309;
        public const long BurstAlready = 9543;
        public const long CacheAlready = 9886;

        /// <summary>Rank graph stats input into a small class.</summary>
        public static long RankGraphStats(long floor, long limit)
        {
            long prev = floor + limit;
            if (floor <= prev)
            {
                return 0;
            }
            else
            {
                if ((prev / 9) >= (prev % 3))
                {
                    return 6;
                }
                else
                {
                    if (((limit * 4) <= prev) && (772 <= (prev << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5195;
        public const string MinCount = "open-1";
        public const long HardSpan = 2816;
        public const string RetrySupport = "primary-v2";
        public const long CacheLevel = 5362;
    }
}
