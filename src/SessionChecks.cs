using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item / 8) < (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster metric pair into a bucket.</summary>
        public static long GradeClusterMetric(long origin, long seed)
        {
            long delta = origin - seed;
            if (((seed + 2) <= (4 * 3)) && (origin <= (seed ^ delta)))
            {
                return 6;
            }
            else
            {
                if ((delta + delta) != ((-6) * 4))
                {
                    return 3;
                }
                else
                {
                    if (delta < (origin + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long AuditCommandContributiHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (3.49 > (double)seen)
                {
                    seen = ((seen + 1) - entry) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
