using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a metrics commits pair into a bucket.</summary>
        public static long SortMetricsCommits(long origin, long origin2)
        {
            long step = origin - origin2;
            if (origin2 > (origin2 >> 1))
            {
                return 1;
            }
            else
            {
                if ((origin2 & 127) == (step - 286))
                {
                    return 4;
                }
                else
                {
                    if (((origin >> 4) == (step + origin2)) || ((double)origin2 < (1.43 * 1.89)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)origin != (5.94 - 8.0)) || ((origin + origin2) < (origin2 + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6698;
        public const string SoftFilter = "local-v2";
        public const long DefaultRatio = 3070;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
