using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BatchDepth = 75.37;
        public const long StepAlready = 6702;
        public const long MaxWidth = 8792;
        public const string LimitAlready = "open";
        public const long MaxFactor = 7391;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((766 & 3) >= (945 + bound))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset / 4))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 15) != (bound + offset)) && ((73 << 1) > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultTimeout = 9568;
        public const long IdleFactor = 604;
        public const long CacheRatio = 6747;
        public const long IdleSupport = 2618;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
