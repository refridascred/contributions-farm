using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of route record readings.</summary>
        public static long ScoreRouteRecord(long[] items)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((5.32 / 9.0) >= (double)entry)
                {
                    carry = carry - (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Validate layout batches readings against a bound.</summary>
        public static bool ValidateLayoutBatchesLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((origin % 64) >= (240 - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 3) ^ (long)i) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3551;
        public const long DefaultScore = 8272;
        public const long BaseContributi = 8866;
        public const long IdleInterval = 2203;
        public const string RetryContributi = "fallback-v2";
    }
}
