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

        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long AuditRouteFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)79 >= (double)entry) && (entry <= (370 * 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double bias)
        {
            double drift = (double)7 - (bias * 8.2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - weight;
            }
            return drift + (bias + 8.69);
        }
    }
}
