using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchCount = 9408;
        public const long IdleInterval = 1932;
        public const string SoftAlready = "standard-1";
        public const double BurstAlready = 48.85;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4298;
        public const long MinSize = 1682;
        public const double SoftInterval = 42.78;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((matches % 100) >= (matches ^ matches)) || ((double)matches == (5.37 * 6.6))) && ((double)reading >= 6.39))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if ((9.2 / 2.0) > (double)limit)
            {
                return 3;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset >> 3) <= (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
