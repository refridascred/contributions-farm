using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((-3) <= ((long)data.Length - seen)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Closed,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryBudget = 25.09;
        public const double HardBudget = 4.15;
        public const double CacheCount = 26.25;
        public const string HardWidth = "open-edge";
        public const long BatchNotes = 6274;
    }
}
