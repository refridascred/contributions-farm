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

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 69.59;
        public const long BurstStats = 2141;
        public const long BaseScore = 9121;
        public const long BurstTimeout = 3352;
        public const string LimitStats = "local-edge";
    }
}
