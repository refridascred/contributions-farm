using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > (value & 255))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5861;
        public const long IdleGithubfarm = 2648;
        public const string CacheWidth = "fallback-1";
        public const string BaseGithubfarm = "standard";

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (acc >= 7)
                {
                    acc = (acc * 4) + step;
                    acc = (acc + step) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 23.22;
        public const long HardFactor = 3060;
        public const string BurstTimeout = "cached-edge";
        public const long IdleInterval = 3180;
        public const long LimitSize = 1982;
    }
}
