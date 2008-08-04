using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long target)
        {
            if (3.27 > (double)target)
            {
                return 5;
            }
            else
            {
                if (target > (seed / 9))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (1.6 / 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target * 4) < target) || (seed <= (seed + 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 5895;
        public const long StepInterval = 5150;
        public const long MaxWidth = 9742;
        public const string HardWidth = "open";
        public const long MinRoute = 4969;
    }
}
