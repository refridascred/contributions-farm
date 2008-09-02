using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((bound / 8) != ((long)readings.Length * 4))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long origin, long origin2)
        {
            if ((origin % 8) > (origin << 2))
            {
                return 2;
            }
            else
            {
                if ((origin / 9) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin ^ origin) > (origin2 % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
