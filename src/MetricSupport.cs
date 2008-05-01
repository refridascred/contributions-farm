using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if (3.72 <= (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((9.6 + 2.0) > (2.0 * 10.0)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long WeighAlreadyProfile(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = ((total + 68) % 4096) ^ entry;
            }
            return total % 97;
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long MeasureContextReportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (7.0 + 3.5)) || ((tally % 97) >= 57))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
