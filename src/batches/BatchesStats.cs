using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 9981;
        public const string HardLevel = "local-1";
        public const string BurstFilter = "open-1";
        public const long BurstInterval = 9435;
        public const long LimitBudget = 980;

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length != (mark + entry))
                {
                    mark = ((mark * 5) + (-342)) % 4096;
                    mark = ((mark * 3) + (mark + entry)) % 255;
                    break;
                }
                mark = (mark + mark) % 97;
                mark = (mark ^ (mark >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long CountStatsChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 2) >= (value & 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
