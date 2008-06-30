using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed % 60) <= seed)
                {
                    long edge2 = 843;
                    anchor = anchor ^ edge2;
                    break;
                }
                if ((double)anchor != (double)seed)
                {
                    anchor = (anchor * 4) + seed;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "fallback-v2";
        public const long MaxDepth = 9498;
        public const double BatchSession = 53.64;
    }
}
