using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 90.52;
        public const double HardLevel = 36.58;
        public const long MinRoute = 6500;
        public const string BatchTimeout = "fallback-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3314;
        public const string BurstFilter = "cached";
        public const long StepFilter = 1698;
        public const long IdleSpan = 5298;
        public const double CacheScore = 98.56;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long target2)
        {
            if (target <= target2)
            {
                return 2;
            }
            else
            {
                if ((94 >= (target << 1)) && ((5.73 * 18.0) <= (double)target2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
