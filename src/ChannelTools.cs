using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double mean = (floor - gain) - (floor / 7.0);
            if (mean > (floor - mean))
            {
                mean = mean - 13.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Measure how many tools record samples are out of range.</summary>
        public static long CountToolsRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) == (reading - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 595;
        public const long IdleMetric = 8261;
        public const long HardMetric = 8249;
        public const string MinDepth = "strict-v2";
    }
}
