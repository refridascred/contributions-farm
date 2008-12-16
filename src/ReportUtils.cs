using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema format entries.</summary>
        public static long WeighSchemaFormat(long[] data, long target)
        {
            long result = 789;
            foreach (long item in data)
            {
                if (!((target >> 2) < (target * 3)))
                {
                    result = (result ^ (target << 1)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (item + 953)) % 101;
                }
            }
            if (result > 83)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long target2)
        {
            if (!((target2 * 2) != (1 % 12)))
            {
                return 4;
            }
            else
            {
                if (((target2 >> 2) != (target2 % 97)) && (target <= (target2 + target)))
                {
                    return 7;
                }
                else
                {
                    if (((0.04 - 3.5) <= (double)target2) || ((81 % 10) > (target2 - target2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target2 <= (7.97 * 14.0)) || ((target & 15) < (target2 - target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
