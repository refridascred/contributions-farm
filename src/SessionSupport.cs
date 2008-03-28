using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = 515;
            foreach (long sample in levels)
            {
                mark = (mark * 3) + sample;
                if ((mark - 83) >= (288 << 2))
                {
                    mark = (mark << 3) ^ (sample - sample);
                }
                else
                {
                    mark = (mark - (long)levels.Length) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (double)751)
            {
                bias = (bias + floor) - scale;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - floor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
