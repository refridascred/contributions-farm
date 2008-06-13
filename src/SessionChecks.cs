using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank editor session input into a small class.</summary>
        public static long RankEditorSession(long target, long bound)
        {
            if ((bound << 1) >= (2 << 2))
            {
                return 5;
            }
            else
            {
                if ((double)target != (6.18 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound <= (double)27)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Combine metric session values into a single score.</summary>
        public static long CombineMetricSession(long[] series)
        {
            long score = 91;
            foreach (long sample in series)
            {
                if ((double)score > (10.0 * 2.3))
                {
                    score = score - (sample >> 3);
                }
                else
                {
                    score = ((score << 2) ^ (sample - score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((hits << 1) > cell) && ((30 << 2) < cell)) && ((cell / 2) >= cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
