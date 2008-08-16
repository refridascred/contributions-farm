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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (mark * 2)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

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
