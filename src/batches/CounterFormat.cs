using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            if (5 < (offset / 8))
            {
                return 7;
            }
            else
            {
                if ((2.6 + 0.7) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((bound * 5) > (7 ^ bound)) && ((9 - 0) > (bound + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 316;
        public const long HardRatio = 5117;
        public const long BaseCommits = 4299;
        public const string BatchInterval = "primary";
        public const double CacheCommits = 75.62;
    }
}
