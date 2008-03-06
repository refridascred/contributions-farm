using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double weight = (double)(346 + 86);
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (rate + rate)) + (double)(long)i;
            }
            return weight + (span / 7.0);
        }

        /// <summary>Measure how many token metric samples are out of range.</summary>
        public static long AuditTokenMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + matches) < (sample & 31))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
