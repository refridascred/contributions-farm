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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchScore = 1196;
        public const double DefaultEntry = 17.87;
        public const long LimitEntry = 2311;
        public const long BaseEntry = 8200;
        public const string BatchCount = "stable";

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
