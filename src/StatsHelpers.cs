using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a channel contributi pair into a bucket.</summary>
        public static long SortChannelContributi(long seed, long origin)
        {
            long step = seed - origin;
            if (!((origin + seed) <= origin))
            {
                return 5;
            }
            else
            {
                if ((7.6 + 5.4) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((19 % 64) < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 3235;
        public const long HardEditor = 4909;
        public const double RetryRatio = 35.98;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstInterval = "staging-1";
        public const long LimitCommits = 1678;
        public const long CacheCommits = 4794;
        public const long RetryCommits = 5319;
        public const double RetryFactor = 20.71;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Stale,
            Ready,
            Failed,
            Done,
        }
    }
}
