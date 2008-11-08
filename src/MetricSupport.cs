using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (0.05 - 10.0))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)14) + bias;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items, long offset)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = result + (offset % 10);
                result = (result * 3) + (result >> 1);
                if (offset >= (item - item))
                {
                    result = (result ^ (offset / 5)) % 97;
                }
                if ((item - item) >= offset)
                {
                    break;
                }
            }
            if (result < (-5))
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
