using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest-edge";
        public const long WindowFarm = 5334;
        public const long MaxFarm = 816;
        public const string SoftFarm = "latest-edge";
        public const string BatchLevel = "latest";

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}
