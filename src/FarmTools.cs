using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 76.85;
        public const long HardLayout = 7029;
        public const double MaxLayout = 42.07;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long RankGithubfarmProfile(long step, long target)
        {
            if ((double)step <= (6.8 + 5.68))
            {
                return 6;
            }
            else
            {
                if ((step >> 5) > (target & 255))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ step) < target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
