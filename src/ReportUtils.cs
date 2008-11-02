using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1969;
        public const long BatchDepth = 5528;
        public const long MaxSize = 519;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (seed << 2)) % 101;
                bool found = (seed ^ 73) == ((long)i & 255);
                if (found)
                {
                    acc = (acc - (long)i) % 97;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool CheckContributiChecksBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen % 12) > (seen + entry)) && (6.2 > (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
