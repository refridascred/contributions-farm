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

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
