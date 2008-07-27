using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + ((long)i + sum)) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 8542;
        public const long HardFactor = 6786;
        public const double CacheEntry = 64.22;
        public const string BurstTimeout = "primary-v2";

        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long StepGithubfarmWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 1) > (9 % 60))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
