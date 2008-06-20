using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Done,
            Ready,
            Idle,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (bound > sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((3.68 * 0.82) != (double)tally) || ((value - 11) >= (value >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
