using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 2592;
        public const long MaxBuffer = 4414;
        public const long BaseBuffer = 5042;
        public const double DefaultBuffer = 49.76;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long limit)
        {
            long gap = step - limit;
            if ((step << 3) <= gap)
            {
                return 5;
            }
            else
            {
                if ((step * 5) < (948 + gap))
                {
                    return 2;
                }
                else
                {
                    if (!((limit % 7) != (step - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
