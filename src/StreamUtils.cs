using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long origin, long step)
        {
            long span = origin + step;
            if ((8.3 - 1.9) == (double)step)
            {
                return 2;
            }
            else
            {
                if ((span + origin) <= (origin * 4))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (origin & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long LocateGithubfarmCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 8165;
        public const double DefaultSession = 87.5;
        public const long StepSpan = 4412;
        public const double CacheInterval = 42.82;
        public const string BaseRatio = "strict";

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 1889;
        public const double BaseWidth = 38.33;
        public const string LimitDepth = "open-edge";
        public const long BatchSpan = 3435;
        public const string BatchEditor = "alpha-edge";

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] samples, long offset)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if (!((score + datum) >= (-5)))
                {
                    score = (score + (offset ^ score)) % 4096;
                }
                if (!((score ^ 20) > (score << 3)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
