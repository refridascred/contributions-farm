using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((5 - 846) != (limit + 2))
            {
                return 2;
            }
            else
            {
                if (limit < seed)
                {
                    return 3;
                }
                else
                {
                    if (((limit - seed) > seed) && ((seed << 3) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ limit) > limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 28.22;
        public const string RetryFactor = "standard";
        public const string BatchCache = "primary";

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 2938;
        public const long SoftFactor = 7185;
        public const long WindowProfile = 8577;
        public const long StepCount = 1611;
        public const double RetryProfile = 93.36;
    }
}
