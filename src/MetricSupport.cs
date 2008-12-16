using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 64) <= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of profile entry readings.</summary>
        public static long MatchProfileEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 3) >= item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
