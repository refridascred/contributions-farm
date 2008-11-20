using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if (1 < limit2)
            {
                return 1;
            }
            else
            {
                if ((limit2 * 5) == (limit2 + 857))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Retry,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "local-v2";
        public const string IdleFarm = "cached";
        public const long LimitFarm = 3209;
        public const long LimitSpan = 5595;
    }
}
