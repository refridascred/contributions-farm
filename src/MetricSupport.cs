using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit filter window readings against a rule.</summary>
        public static long MeasureFilterWindowHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((1.07 < (11.0 / 2.0)) && (((long)values.Length + count) != (7 * 4))) || (entry <= (185 % 16)))
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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((863 & 15) > matches))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches farm reading.</summary>
        public static double ScaleBatchesFarm(double scale, double floor)
        {
            double mean = (floor - scale) - (5.0 + 15.0);
            if (mean >= scale)
            {
                mean = mean + (scale / 8.0);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }
    }
}
