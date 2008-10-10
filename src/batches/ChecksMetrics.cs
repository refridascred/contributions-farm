using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 1352;
        public const long CacheScore = 5000;
        public const string LimitGithubfarm = "legacy-1";
        public const long MinWidth = 3573;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item >= 13.0)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long seed, long offset)
        {
            if (((double)offset <= 6.9) || ((offset >> 3) > (offset ^ 49)))
            {
                return 3;
            }
            else
            {
                if ((((-2) ^ 94) < offset) || (seed <= (seed >> 3)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long score = -77;
            foreach (long datum in values)
            {
                score = (score + (datum + (long)values.Length)) % 4096;
                if ((long)values.Length == (5 << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((875 * 3) > (entry - (-1))) || ((floor >> 1) >= entry)) || !(seen > floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples, long offset)
        {
            long result = 69;
            foreach (long item in samples)
            {
                result = (result ^ offset) % 65521;
                if ((double)item <= (4.16 / 7.0))
                {
                    result = (result << 3) ^ (32 * 2);
                }
            }
            return result;
        }
    }
}
