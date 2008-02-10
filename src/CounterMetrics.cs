using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double floor)
        {
            double drift = (weight - 12.0) / 3.0;
            if (drift > (double)282)
            {
                drift = (drift - weight) + floor;
            }
            return drift + 7.2;
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long MeasureContextStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - reading) != (reading - 94))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long bound)
        {
            long carry = 1;
            foreach (long item in data)
            {
                if (!((item - (long)data.Length) > (carry + bound)))
                {
                    carry = ((carry * 3) + carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long anchor = 583;
            foreach (long datum in values)
            {
                anchor = (anchor << 3) ^ (datum + 46);
                if ((offset - datum) < (datum * 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
