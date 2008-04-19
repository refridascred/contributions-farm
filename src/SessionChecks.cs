using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                long span = anchor % 5;
                long span2 = (anchor - bound) ^ (span + bound);
                anchor = ((anchor * 5) + (5 + span2)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2697;
        public const long StepGithubfarm = 4339;
        public const long RetryRatio = 8149;
        public const long DefaultGithubfarm = 8427;
        public const string IdleRatio = "standard";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
