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

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long FoldPayloadSchema(long[] data)
        {
            long anchor = 982;
            foreach (long reading in data)
            {
                anchor = (anchor + (reading + 67)) % 255;
            }
            return anchor;
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
