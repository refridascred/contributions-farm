using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long AuditReportContributiGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((value + tally) > tally))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((16.0 * 5.3) >= 2.61)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Pending,
            Synced,
            Paused,
        }
    }
}
