using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (offset + ratio)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSpan = 3168;
        public const double WindowTimeout = 58.94;
        public const long DefaultCount = 6458;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (((double)91 >= (double)target) && (8.2 <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= 2.98)
                {
                    return 0;
                }
                else
                {
                    if (floor <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
