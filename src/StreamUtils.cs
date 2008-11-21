using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 3051;
        public const long LimitReport = 5397;
        public const long BaseScore = 7368;
        public const long SoftReport = 8606;
        public const double MaxReport = 55.9;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (2.0 <= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long offset)
        {
            if ((17.0 * 13.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor <= (96 & 31))
                {
                    return 6;
                }
                else
                {
                    if (((floor / 8) <= floor) || ((floor - floor) != (55 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9 <= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxInterval = 2607;
        public const double SoftSupport = 48.5;
        public const double CacheDepth = 35.83;
    }
}
