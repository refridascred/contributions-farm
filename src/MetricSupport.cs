using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate report metrics readings against a bound.</summary>
        public static bool ValidateReportMetricsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm record readings against a bound.</summary>
        public static bool GuardGithubfarmRecordLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long MeasureReportPayloadGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches & 1) != (value ^ value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
