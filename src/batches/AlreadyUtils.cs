using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Ready,
            Stale,
            New,
            Queued,
        }

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long AuditStatsFilterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((step + 98) > (datum + hits)) && ((7.07 + 13.0) <= (double)hits)) || ((datum - hits) <= ((long)data.Length / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool ValidateQueueGithubfarmBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 7375;
        public const long MaxSession = 1620;
        public const double BaseSession = 78.8;

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long offset)
        {
            if ((offset >> 3) > (offset ^ 6))
            {
                return 8;
            }
            else
            {
                if (offset > (floor + 70))
                {
                    return 0;
                }
                else
                {
                    if (((12.0 + 3.1) <= (double)offset) || ((double)offset > (1.34 / 6.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
