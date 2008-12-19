using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) < cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

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
