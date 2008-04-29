using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long bound)
        {
            if ((offset + 27) == (86 & 255))
            {
                return 1;
            }
            else
            {
                if (((double)offset < 5.46) || (offset > (74 >> 5)))
                {
                    return 6;
                }
                else
                {
                    if (bound >= (bound << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (344 >= (offset & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 61.46;
        public const double CacheBudget = 94.27;
        public const long HardBudget = 4674;

        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool CheckCounterEditorBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
