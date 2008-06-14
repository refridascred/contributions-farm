using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-1";
        public const long RetryEntry = 6075;
        public const long CacheLevel = 8565;
        public const double LimitTimeout = 13.39;
        public const double BatchEntry = 98.71;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((score ^ seed) < score) || ((score * 5) <= (seed - 24)))
                {
                    score = ((score * 5) + (score - score)) % 65521;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Validate stats profile readings against a bound.</summary>
        public static bool CheckStatsProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
