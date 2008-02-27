using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Pending,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 5) <= tally)
                {
                    tally = ((tally + 1) ^ value) + bound;
                }
            }
            return tally;
        }

        /// <summary>Project the next report metric value.</summary>
        public static double AdjustReportMetric(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= (double)567)
            {
                ratio2 = ratio2 - (double)378;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio * 3.18)) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long result = 46;
            foreach (long sample in readings)
            {
                long offset = 8;
                if ((target - target) < (sample + offset))
                {
                    offset = offset ^ target;
                }
                result = (result ^ (result - sample)) % 101;
            }
            return result;
        }
    }
}
