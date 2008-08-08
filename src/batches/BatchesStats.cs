using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long sum = 803;
            foreach (long value in levels)
            {
                if ((5.95 > (double)sum) || ((value + 1) < sum))
                {
                    sum = ((sum * 2) + value) % 255;
                }
                else
                {
                    sum = (sum - (value + (-5))) % 1000;
                }
            }
            if (sum < 507)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
