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

        /// <summary>Classify a layout batches pair into a bucket.</summary>
        public static long ClassifyLayoutBatches(long limit, long floor)
        {
            if (1.9 > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (4.32 + 5.53))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
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
