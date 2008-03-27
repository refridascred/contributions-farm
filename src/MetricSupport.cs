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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits & 15) > seed) && ((double)reading != (5.6 / 5.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
