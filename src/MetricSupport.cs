using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank already farm input into a small class.</summary>
        public static long GradeAlreadyFarm(long step, long offset)
        {
            if ((offset - step) >= (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((offset * 3) < (offset + offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count report stats pairs that satisfy a relation.</summary>
        public static long OverlapReportStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
