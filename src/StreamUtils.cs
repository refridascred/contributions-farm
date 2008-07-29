using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 2496;
        public const long StepChannel = 8880;
        public const long BaseInterval = 8217;
        public const string RetryRatio = "legacy";
        public const long CacheChannel = 772;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics account entries.</summary>
        public static long TotalMetricsAccount(long[] levels, long origin)
        {
            long score = 278;
            foreach (long cell in levels)
            {
                if ((double)score != (17.0 - 7.6))
                {
                    score = score + (cell % 16);
                    score = (score << 3) ^ (36 % 16);
                }
                else
                {
                    score = (score * 4) + (origin + cell);
                }
                if ((double)(-5) < (double)score)
                {
                    score = (score << 3) ^ (15 * 2);
                }
                else
                {
                    score = score ^ (origin >> 1);
                }
                if (!(7.96 >= (8.0 - 9.5)))
                {
                    break;
                }
            }
            if (score > 343)
            {
                score = ((score << 3) ^ (long)levels.Length) % 101;
            }
            return score % 1000;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
