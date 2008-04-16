using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 2.13;
        public const long MinInterval = 4411;
        public const long StepSchema = 3989;
        public const long IdleSchema = 562;
        public const long BaseBudget = 9152;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long target, long target2)
        {
            if (((double)target2 > 6.04) || ((target2 / 6) > (target2 + target)))
            {
                return 4;
            }
            else
            {
                if ((target % 64) > target)
                {
                    return 5;
                }
                else
                {
                    if (target >= (target - 14))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.8 * 2.07) >= (double)target2)
                        {
                            return 2;
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
