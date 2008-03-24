using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double mean = (1.59 - offset) + (double)22;
            if (mean < (offset + offset))
            {
                mean = mean - (scale * 3.09);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (offset + 8.0)) + (double)(long)i;
            }
            return mean + (mean * 5.8);
        }

        /// <summary>Match up token stream samples.</summary>
        public static long OverlapTokenStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (double)0)
            {
                scale2 = (scale2 - (double)675) - scale;
            }
            return scale2 - offset;
        }
    }
}
