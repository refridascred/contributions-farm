using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two batches report measurements.</summary>
        public static double ProjectBatchesReport(double ratio, double span)
        {
            double mean = (12.0 - 6.6) * 15.0;
            if (mean >= 6.0)
            {
                mean = mean + (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean + (double)355;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double AdjustBatchAlready(double weight, double span)
        {
            double mean = (weight + weight) - weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - span;
            }
            return mean + (weight - mean);
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long MeasureStreamTokenHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value << 2) <= (621 & 255))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
