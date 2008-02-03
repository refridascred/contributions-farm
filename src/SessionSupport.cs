using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm stream readings against a bound.</summary>
        public static bool CheckGithubfarmStreamRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cache layout pair into a bucket.</summary>
        public static long GradeCacheLayout(long step, long limit)
        {
            if ((limit + step) != (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((step * 4) < (step & 255))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
