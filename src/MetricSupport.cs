using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                if ((2.17 - 1.6) > (double)cell)
                {
                    score = ((score * 5) + (score >> 4)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long RankContributiChecks(long bound, long step)
        {
            long next = bound - step;
            if (!((bound >> 2) == (step ^ 688)))
            {
                return 8;
            }
            else
            {
                if (((step & 127) > next) || (bound > (next % 12)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
