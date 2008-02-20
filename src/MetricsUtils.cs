using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long sum = 0;
            foreach (long sample in items)
            {
                if (((origin / 7) < origin) && ((sample + origin) >= origin))
                {
                    sum = sum ^ (49 >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum << 3) ^ (bound - bound);
                sum = (sum << 3) ^ sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a stream entry reading by value.</summary>
        public static long SeekStreamEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Failed,
            Idle,
            Synced,
        }
    }
}
