using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
