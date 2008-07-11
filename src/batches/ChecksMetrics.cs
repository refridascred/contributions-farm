using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the route stats series from a seed.</summary>
        public static long SeriesRouteStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 3) ^ (acc + (long)i)) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Iterate the cache githubfarm series from a seed.</summary>
        public static long RollCacheGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state - bound) % 97;
                if ((double)5 != (double)(long)i)
                {
                    state = state - (state + (long)i);
                }
                if ((long)i > (state ^ (long)i))
                {
                    state = state + (bound - state);
                    state = (state << 3) ^ state;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCount = "alpha-edge";
        public const long StepFactor = 8206;
        public const long HardCount = 4104;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 8401;
        public const long DefaultFactor = 3711;
        public const long HardSize = 1102;
        public const double DefaultSpan = 78.03;
        public const long BaseWidth = 1873;
    }
}
