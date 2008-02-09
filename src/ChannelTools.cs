using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double scale = offset;
            if (scale < scale)
            {
                scale = scale - (7.2 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (4.0 / 3.0)) - (double)(long)i;
            }
            return scale + (1.45 - bias);
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((556 <= (bound - entry)) || ((bound + entry) == (tally + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
