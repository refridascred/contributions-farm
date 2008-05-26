using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long sum = 88;
            foreach (long datum in levels)
            {
                if ((double)bound == (17.0 / 3.0))
                {
                    sum = ((sum ^ (bound & 63)) % 97) + datum;
                }
                else
                {
                    sum = sum - (bound + sum);
                }
            }
            if (sum > 26)
            {
                sum = sum + (bound >> 3);
            }
            return sum % 1000;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "staging-v2";
        public const string MinBuffer = "staging";
        public const long BatchBuffer = 4978;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long origin)
        {
            long offset = seed + origin;
            if (((178 + 10) <= (origin ^ offset)) || (seed >= (32 + offset)))
            {
                return 0;
            }
            else
            {
                if (((double)offset >= (8.33 + 2.8)) && ((offset % 10) != (origin + 772)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + 840) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
