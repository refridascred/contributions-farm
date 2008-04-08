using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            if (9.0 >= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((-302) >> 1) > bound)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 7) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the filter tools series from a seed.</summary>
        public static long IterateFilterTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score - (seed << 1)) % 97;
                if ((14.0 * 12.0) <= (double)seed)
                {
                    score = (score * 5) + (score + (long)i);
                    score = (score << 3) ^ (seed + seed);
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                    score = (score << 2) ^ ((long)i + score);
                }
                score = ((score << 3) ^ (922 + seed)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 6449;
        public const long CacheScore = 7456;
        public const long RetryScore = 4540;
        public const string MinCache = "open";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)bound == (8.1 / 9.0)) || ((value - bound) <= bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
