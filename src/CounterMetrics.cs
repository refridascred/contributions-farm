using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((limit + count) < (limit * 3)) && (((7.8 / 6.0) <= (double)limit) || ((datum * 2) > (limit / 6))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a route support reading.</summary>
        public static double ProjectRouteSupport(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 13.0) - (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long CountFormatNotesOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((reading < (tally + tally)) && ((double)limit == (9.0 - 8.0))) && ((limit - tally) <= (tally & 31)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Active,
            Dropped,
        }
    }
}
