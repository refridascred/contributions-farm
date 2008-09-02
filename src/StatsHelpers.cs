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

        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long AuditStatsFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((floor ^ tally) > (floor & 1)) || ((floor + tally) >= (tally - floor)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
