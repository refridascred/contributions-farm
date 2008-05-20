using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double mean = (scale - span) / 9.0;
            if (mean <= scale)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (span / 2.0)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)seen == (3.32 - 7.5)) && ((seen - seen) < (reading + bound)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
