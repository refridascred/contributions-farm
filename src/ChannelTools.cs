using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long TallyMetricsSessionMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count < (441 + value))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double mean = (double)(240 << 3);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (mean / 4.0)) + (double)(long)i) + bias;
            }
            return mean + (ratio / 5.0);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long origin)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if (mark >= ((long)readings.Length + (long)readings.Length))
                {
                    mark = (((mark * 5) + (mark * 4)) - value) - origin;
                }
            }
            return mark;
        }
    }
}
