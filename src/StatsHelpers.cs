using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long offset, long seed)
        {
            if ((seed - 250) != (seed - seed))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) < (seed << 3))
                {
                    return 1;
                }
                else
                {
                    if (7 >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset << 3) < 92)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 5692;
        public const double MinScore = 39.46;
        public const long CacheChannel = 2261;
        public const long MaxChannel = 4814;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Closed,
            Draft,
            Active,
            Stale,
        }
    }
}
