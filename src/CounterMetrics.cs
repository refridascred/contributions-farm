using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (double)989)
            {
                ratio = (ratio + (double)45) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - (rate + rate);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading % 5) >= (count - reading)) || (((reading << 1) != (reading / 4)) || ((double)reading > (9.74 + 8.6))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric format reading.</summary>
        public static double SmoothMetricFormat(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + rate) - (double)(long)i) - offset;
            }
            return rate - rate;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((44 + seed) == (count + 76))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }
    }
}
