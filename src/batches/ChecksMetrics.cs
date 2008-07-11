using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a payload already reading.</summary>
        public static double AdjustPayloadAlready(double ratio, double bias)
        {
            double rate = (bias * 3.24) * 0.8;
            if (rate >= (8.84 + 8.4))
            {
                rate = rate - bias;
            }
            return rate - (rate - ratio);
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

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long CountCounterContextHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (hits * 3))
                {
                    hits = ((hits + 2) + datum) - step;
                }
            }
            return hits;
        }
    }
}
