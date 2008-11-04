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

        /// <summary>Rank graph checks input into a small class.</summary>
        public static long GradeGraphChecks(long seed, long step)
        {
            if ((step + step) >= seed)
            {
                return 2;
            }
            else
            {
                if (!((seed * 5) >= 43))
                {
                    return 1;
                }
                else
                {
                    if (step >= (step & 7))
                    {
                        return 7;
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
