using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next window command value.</summary>
        public static double ScaleWindowCommand(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > offset)
            {
                drift = drift + (drift - offset);
            }
            else
            {
                drift = drift - (double)596;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 4.6) + (double)(long)i;
            }
            return drift + 14.0;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long bound)
        {
            if (((limit - limit) > (675 + bound)) || (limit < (bound ^ limit)))
            {
                return 4;
            }
            else
            {
                if ((double)limit == (8.3 + 7.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
