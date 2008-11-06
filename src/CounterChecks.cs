using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BatchFactor = 96.98;
        public const double BaseSpan = 25.85;
        public const double BatchCount = 9.45;
        public const long WindowRoute = 6491;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 570;
        public const long HardGithubfarm = 9421;
        public const double DefaultSize = 87.94;
        public const string RetryTimeout = "staging-v2";

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                long offset2 = offset ^ (long)i;
                if (((state % 64) < offset2) && (((long)i * 4) != (state / 4)))
                {
                    state = state - state;
                    state = (state - (5 - 2)) % 1000;
                }
                state = (state + ((long)i * 4)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((seed + seed) <= 840)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
