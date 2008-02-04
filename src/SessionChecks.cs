using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark * 3) + (mark >> 5)) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 7609;
        public const string DefaultRoute = "fallback-v2";
        public const long BurstInterval = 1706;

        /// <summary>Find the first cache githubfarm entry that matches the target.</summary>
        public static long FindCacheGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((1.9 / 2.0) >= (9.46 * 5.0))
                {
                    matches = ((matches + 2) + sample) - offset;
                }
            }
            return matches;
        }
    }
}
