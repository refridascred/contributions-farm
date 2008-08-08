using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long GradeLayoutChecks(long seed, long bound)
        {
            long lane = seed - bound;
            if (((seed - seed) < (lane / 5)) || ((422 >> 1) == (12 - lane)))
            {
                return 5;
            }
            else
            {
                if (((3.95 - 12.0) > (double)bound) || ((seed << 2) == (bound / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((bound / 8) > lane)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.53 + 3.0) <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
