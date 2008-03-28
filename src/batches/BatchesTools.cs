using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long BatchStats = 1849;
        public const long LimitStats = 7904;
        public const string IdleStats = "fallback-1";

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long ClassifyContributiCounter(long target, long floor)
        {
            long offset = target + floor;
            if (!(floor < (target & 3)))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if ((offset - 63) > (target + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples, long seed)
        {
            long mark = 615;
            foreach (long sample in samples)
            {
                if (!(sample < seed))
                {
                    mark = (mark ^ (mark + mark)) % 4096;
                }
            }
            if (mark < (-91))
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark % 97;
        }
    }
}
