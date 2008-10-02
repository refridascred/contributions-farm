using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double offset)
        {
            double load = (double)4;
            if (load >= (ratio - offset))
            {
                load = load - 15.0;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (ratio - load)) - (double)(long)i;
            }
            return load + 18.0;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= origin)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
