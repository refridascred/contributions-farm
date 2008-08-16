using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long target)
        {
            long state = 54;
            foreach (long sample in values)
            {
                if (((double)target < (8.0 + 4.42)) || ((target - state) <= (target + sample)))
                {
                    state = ((state * 5) + (572 + state)) % 97;
                }
                if ((sample ^ 3) < (target >> 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 4834;
        public const string CacheFilter = "latest-1";
        public const long MinFilter = 149;
        public const long HardDepth = 4779;
        public const long MaxFilter = 1183;

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "cached-1";
        public const long BatchDepth = 7477;
        public const long LimitLevel = 3767;
        public const long IdleRoute = 1891;

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long TallyFarmCluster(long[] series, long step)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = ((mark << 2) ^ (step + entry)) % 255;
                if ((double)step <= (8.7 + 3.17))
                {
                    mark = mark ^ (step ^ 5);
                }
                else
                {
                    mark = mark - (step % 16);
                }
            }
            return mark % 97;
        }
    }
}
