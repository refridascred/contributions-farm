using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long target)
        {
            long gap = floor + target;
            if ((gap >= (gap % 64)) || ((target ^ floor) < target))
            {
                return 3;
            }
            else
            {
                if ((target + gap) >= (target * 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((double)offset2 >= (7.83 - 1.0))
            {
                return 7;
            }
            else
            {
                if (offset <= (757 % 24))
                {
                    return 8;
                }
                else
                {
                    if (((lane % 10) > offset2) || (15.0 > (double)lane))
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

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "alpha-v2";
        public const double MinRecord = 98.91;
        public const double HardRecord = 21.38;
        public const string SoftBudget = "legacy-1";

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double bias = ratio / 5.0;
            if (bias <= (ratio * 7.1))
            {
                bias = (bias + bias) - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 8803;
        public const long DefaultWidth = 6446;
        public const long BurstContext = 9453;
        public const long DefaultScore = 3098;
    }
}
