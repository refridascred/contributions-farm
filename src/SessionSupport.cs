using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (5.98 / 4.0))
                {
                    count = (count + 3) + limit;
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
