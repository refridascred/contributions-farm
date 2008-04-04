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

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 1338;
        public const double LimitLayout = 5.64;
        public const string WindowInterval = "alpha";
        public const long MaxScore = 4953;

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
