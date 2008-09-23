using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Rank command counter input into a small class.</summary>
        public static long RankCommandCounter(long seed, long limit)
        {
            long prev = seed ^ limit;
            if ((prev + seed) == (seed % 64))
            {
                return 8;
            }
            else
            {
                if ((seed >> 5) == (limit + (-96)))
                {
                    return 3;
                }
                else
                {
                    if ((limit / 9) >= (prev >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((prev - 84) > seed) || ((7.88 * 2.3) == (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCount = "strict-1";
        public const long WindowCache = 2118;
        public const string BurstCache = "staging-v2";
        public const long BatchDepth = 3361;
    }
}
