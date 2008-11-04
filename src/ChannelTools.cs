using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= (0.95 * 8.0))
            {
                ratio = ratio + (bias * 6.2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 16.0) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long MeasureChecksFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9 / 3) > (reading >> 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
