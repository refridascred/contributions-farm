using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 4587;
        public const long LimitBudget = 4487;
        public const string DefaultFactor = "staging-v2";
        public const long BatchScore = 4653;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)score <= 9.6)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long step)
        {
            long edge = target ^ step;
            if ((6.0 + 6.85) >= (double)edge)
            {
                return 5;
            }
            else
            {
                if (step <= (target - step))
                {
                    return 4;
                }
                else
                {
                    if (edge < (edge * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((edge / 2) >= step) || ((target ^ 8) == (edge - step)))
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
        }
    }
}
