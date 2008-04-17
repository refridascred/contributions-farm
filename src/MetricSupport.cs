using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= (bias + ratio))
            {
                mean = mean - (bias + bias);
            }
            else
            {
                mean = mean + 16.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + 3.0;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = -6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (total + (total + (long)data.Length)) + (long)i;
                }
                if ((entry % 3) == (entry % 12))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = total - (total >> 1);
                }
            }
            return total;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < (double)origin)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
