using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mark = 50;
            foreach (long value in items)
            {
                if ((double)value >= 12.0)
                {
                    mark = mark ^ (value % 100);
                }
                if (((double)value < 4.0) || ((value >> 3) <= (value & 3)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitWidth = 3692;
        public const long BaseFilter = 1716;
        public const double CacheFilter = 85.38;
        public const double MinFilter = 16.0;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits > (reading & 1))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values, long floor)
        {
            long state = -99;
            foreach (long sample in values)
            {
                state = (state - (floor - sample)) % 65521;
                state = state - (sample * 4);
            }
            return state % 97;
        }
    }
}
