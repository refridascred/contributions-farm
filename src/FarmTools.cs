using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchWidth = 6.39;
        public const double HardChannel = 35.23;
        public const double CacheChannel = 62.73;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long floor)
        {
            if ((double)target == (6.0 - 6.32))
            {
                return 1;
            }
            else
            {
                if ((target + target) <= (-8))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 15) == (floor >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target - target) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowBudget = 591;
        public const long IdleFactor = 2477;
        public const long WindowSize = 5193;
        public const long RetryFarm = 634;
        public const string BurstSize = "legacy-edge";
    }
}
