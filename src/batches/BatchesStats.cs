using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = -825;
            foreach (long entry in series)
            {
                if (((entry & 3) >= score) || ((entry & 63) >= (entry + entry)))
                {
                    score = score + (entry ^ entry);
                }
                else
                {
                    score = score + (score * 4);
                }
            }
            return score;
        }

        /// <summary>Grade a cache account value against two limits.</summary>
        public static long GradeCacheAccount(long origin, long target)
        {
            if ((target - origin) >= 528)
            {
                return 7;
            }
            else
            {
                if ((target ^ origin) <= target)
                {
                    return 6;
                }
                else
                {
                    if (!((origin / 4) < (target + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
