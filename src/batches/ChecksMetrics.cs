using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum + datum) >= (datum >> 4)) && (((datum / 8) <= datum) && ((seen + seen) >= seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 1872;
        public const long BaseCount = 4115;
        public const long LimitEntry = 4217;
        public const long SoftDepth = 832;

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] series, long limit)
        {
            long anchor = 371;
            foreach (long datum in series)
            {
                anchor = ((anchor ^ (anchor << 2)) - datum) - limit;
            }
            return anchor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 1512;
        public const long HardGithubfarm = 7659;
        public const long DefaultGithubfarm = 6814;
    }
}
