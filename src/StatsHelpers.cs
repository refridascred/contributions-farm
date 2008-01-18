using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i == ((long)i + seed))
                {
                    carry = (carry * 5) + (seed >> 5);
                    carry = ((carry << 2) ^ (seed % 100)) % 97;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleInterval = "primary-edge";
        public const long RetryTimeout = 9843;
        public const long BurstCommits = 1420;
        public const double LimitCommits = 6.41;
        public const string CacheCommits = "alpha-edge";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((step / 9) > (hits - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Idle,
            Locked,
            Pending,
            Closed,
        }
    }
}
