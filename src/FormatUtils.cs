using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long bound)
        {
            long sum = 1;
            foreach (long cell in series)
            {
                sum = (sum ^ (sum - bound)) - cell;
            }
            if (sum < 68)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5969;
        public const double BaseLevel = 82.57;
        public const double IdleWidth = 66.23;
        public const string CacheFilter = "fallback-edge";
        public const long BaseFilter = 6426;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            if ((seed - seed2) >= (seed2 + seed2))
            {
                return 6;
            }
            else
            {
                if ((5.1 * 15.0) == (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
