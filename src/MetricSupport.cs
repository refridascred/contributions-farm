using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the metric report entries that pass the check.</summary>
        public static long TallyMetricReportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((415 << 3) == (tally + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double bias = weight - (weight - span);
            if (bias > (weight * 1.2))
            {
                bias = bias + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 4.1) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (6.65 > (double)origin)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
