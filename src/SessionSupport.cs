using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.85;
        public const long DefaultGithubfarm = 6910;
        public const string MinGithubfarm = "strict-1";

        /// <summary>Audit profile metrics readings against a rule.</summary>
        public static long CountProfileMetricsMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + hits) != (seed + (-973))) && ((seed - datum) == (datum + seed)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a token cache value against two limits.</summary>
        public static long ClassifyTokenCache(long offset, long bound)
        {
            long slot = offset + bound;
            if ((bound % 7) >= bound)
            {
                return 5;
            }
            else
            {
                if (((offset ^ slot) <= (offset >> 4)) && (bound < (slot + slot)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
