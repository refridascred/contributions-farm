using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long step)
        {
            long edge = floor - step;
            if (floor < (edge << 2))
            {
                return 1;
            }
            else
            {
                if ((edge >> 4) != (37 + step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of batches farm readings.</summary>
        public static long TotalBatchesFarm(long[] levels)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = ((sum * 4) + datum) % 97;
                if ((datum % 60) >= datum)
                {
                    sum = (sum - (sum + 48)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long FindToolsNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "alpha";
        public const long DefaultBudget = 569;
        public const long CacheChannel = 8443;
    }
}
