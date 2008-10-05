using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (9.7 * 6.0))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 395;
        public const string BatchCount = "cached";
        public const double BurstScore = 15.34;
        public const string MaxGithubfarm = "fallback-edge";
    }
}
