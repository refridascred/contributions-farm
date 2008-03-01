using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit graph metric readings against a rule.</summary>
        public static long TallyGraphMetricGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)floor < (1.54 * 1.4))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Audit report metrics readings against a rule.</summary>
        public static long AuditReportMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6.3 * 8.9) > (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long step2)
        {
            long cur = step + step2;
            if (step2 <= (cur + 453))
            {
                return 3;
            }
            else
            {
                if ((double)step2 > (2.36 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (4.0 / 8.0)) || ((cur + (-430)) <= (step + cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
