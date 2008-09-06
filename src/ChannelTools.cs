using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long TallyStatsChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((-353) < (value + value)) && ((double)tally >= (double)value)) && ((tally + value) != (tally * 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum >= (datum + 902)) && ((count > offset) || (datum >= (count % 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double bias = 6.22 - gain;
            if (bias > (double)23)
            {
                bias = bias + floor;
            }
            return bias + bias;
        }
    }
}
