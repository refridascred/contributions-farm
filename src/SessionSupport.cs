using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout report samples are out of range.</summary>
        public static long AuditLayoutReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (17.0 - 1.23))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((191 * 2) != (datum ^ 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
