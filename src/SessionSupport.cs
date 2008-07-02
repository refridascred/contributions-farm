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

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
