using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "staging-v2";
        public const string IdleScore = "cached";
        public const string MaxCount = "stable-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) <= (33 << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 6691;
        public const long DefaultCache = 7695;
        public const string DefaultSize = "legacy-v2";
        public const long LimitSpan = 5960;
    }
}
