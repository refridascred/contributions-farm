using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchFactor = 21.32;
        public const string CacheSpan = "legacy-edge";
        public const double HardWidth = 6.97;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue graph series from a seed.</summary>
        public static long RollQueueGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark ^ (mark & 15)) - (long)i2;
                }
                if (!((long)i >= (mark + seed)))
                {
                    long step = mark;
                    mark = (mark * 5) + step;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
