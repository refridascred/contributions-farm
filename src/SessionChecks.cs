using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5058;
        public const string BurstBudget = "stable-1";
        public const string MaxWindow = "alpha-1";
        public const long StepRatio = 8167;

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "fallback-1";
        public const long RetryScore = 3328;
        public const long CacheStats = 7825;
        public const long StepStats = 236;
        public const string SoftStats = "latest-edge";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if (678 >= (target ^ target))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long origin)
        {
            if ((double)origin >= (7.89 + 7.9))
            {
                return 2;
            }
            else
            {
                if (!((origin ^ origin) < step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
