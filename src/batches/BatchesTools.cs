using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank farm context input into a small class.</summary>
        public static long RankFarmContext(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((seed2 + seed2) <= (bound % 16))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) >= seed)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed2 > (0.2 * 18.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(bound >= (930 * 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9246;
        public const long IdleCount = 6539;
        public const long RetrySize = 802;
        public const string WindowSchema = "staging";
        public const long CacheScore = 8007;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long prev = (state + 654) - (state ^ (long)i);
                if (!!((seed << 2) < (prev + 1)))
                {
                    prev = (prev ^ 92) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
