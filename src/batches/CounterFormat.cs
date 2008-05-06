using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long offset2)
        {
            if ((double)offset2 <= 1.2)
            {
                return 6;
            }
            else
            {
                if (((offset + offset) > (9 << 1)) && (offset2 < (offset2 & 3)))
                {
                    return 1;
                }
                else
                {
                    if ((((-62) - offset2) >= offset2) && (offset <= (offset + offset2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double offset)
        {
            double scale = (double)286 - (double)3;
            if (scale >= (ratio + offset))
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)4;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double load = offset;
            return (load + offset) + scale;
        }
    }
}
