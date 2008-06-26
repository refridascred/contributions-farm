using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) <= (cell - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((offset % 60) == (matches + offset))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double load = offset;
            if (load > bias)
            {
                load = load - 16.0;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 19.0) + (double)(long)i;
            }
            return load - offset;
        }
    }
}
