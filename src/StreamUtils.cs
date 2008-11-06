using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowSize = 61.7;
        public const long LimitGithubfarm = 8997;
        public const string HardGithubfarm = "legacy-1";
        public const long WindowSpan = 5423;
        public const long CacheSize = 1444;

        /// <summary>Grade a notes metric value against two limits.</summary>
        public static long ClassifyNotesMetric(long seed, long seed2)
        {
            if (seed > (seed >> 2))
            {
                return 8;
            }
            else
            {
                if ((seed - seed2) >= seed)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the stream already series from a seed.</summary>
        public static long SeriesStreamAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if (seed >= (score << 1))
                {
                    break;
                }
                score = ((score * 3) + (seed ^ score)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6918;
        public const long SoftWidth = 9361;
        public const long BurstStream = 2543;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
