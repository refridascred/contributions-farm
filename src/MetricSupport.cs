using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((edge - offset) >= (edge >> 1))
            {
                return 8;
            }
            else
            {
                if (!((limit >> 5) >= limit))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double load = (double)(5 / 8);
            return ((load - load) + rate) + floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((18.0 + 4.28) != (double)tally)
                {
                    tally = ((tally + 2) + datum) - bound;
                }
            }
            return tally;
        }
    }
}
