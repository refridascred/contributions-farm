using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches != (12.0 - 0.2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long AuditEntryContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double mean = span + 0.1;
            if (mean < (double)(-11))
            {
                mean = (mean + (span - span)) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Done,
            Synced,
            Queued,
        }
    }
}
