using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a githubfarm route value against two limits.</summary>
        public static long RankGithubfarmRoute(long target, long offset)
        {
            if ((target - offset) >= (target & 7))
            {
                return 1;
            }
            else
            {
                if ((target - target) < target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double gain = 14.0;
            return ((gain + 3.0) + scale) + offset;
        }

        /// <summary>Count the notes metrics entries that pass the check.</summary>
        public static long AuditNotesMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum > (hits & 15)) && (((9.7 / 2.0) != (double)datum) || ((double)datum >= 7.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Synced,
            Queued,
            Pending,
            Closed,
        }
    }
}
