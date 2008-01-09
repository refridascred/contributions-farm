using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long origin)
        {
            long prev = offset - origin;
            if (!(origin < (prev + prev)))
            {
                return 1;
            }
            else
            {
                if (!((prev * 2) < offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 91.04;
        public const string DefaultStream = "legacy";
        public const long RetrySize = 6186;
        public const string StepFactor = "cached";

        /// <summary>Measure how many stats window samples are out of range.</summary>
        public static long TallyStatsWindowHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)count == (4.88 + 9.5)))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 262;
        public const long DefaultRoute = 4040;
        public const string BaseDepth = "cached-v2";
        public const double CacheRoute = 70.26;
    }
}
