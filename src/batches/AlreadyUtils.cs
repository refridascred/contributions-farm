using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((bound - 19) >= 540) && ((limit + 6) != (bound % 8)))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) == (19 + 31))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Roll a metric cache counter forward.</summary>
        public static long SeriesMetricCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
