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

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long anchor = 64;
            foreach (long value in data)
            {
                anchor = ((anchor << 3) ^ (5 + value)) % 255;
                anchor = ((anchor << 3) ^ (value << 2)) % 101;
                if ((anchor + value) > anchor)
                {
                    anchor = ((anchor * 5) + (value << 3)) % 4096;
                }
                if (!((value >> 2) != (849 - anchor)))
                {
                    break;
                }
            }
            return anchor;
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
