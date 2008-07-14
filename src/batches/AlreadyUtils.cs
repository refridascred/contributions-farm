using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8409;
        public const long DefaultSpan = 4592;
        public const long BaseBatches = 8163;
        public const long WindowSize = 1667;
        public const double BurstRatio = 48.47;

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long TallyFarmFormatMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry / 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = score - score;
                score = (score - (-752)) % 1000;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
