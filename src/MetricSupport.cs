using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches <= (double)8)
                {
                    matches = ((matches + 2) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples, long floor)
        {
            long acc = 31;
            foreach (long item in samples)
            {
                if (((double)acc < (5.9 + 8.54)) && ((double)floor <= (0.16 / 9.0)))
                {
                    acc = (acc ^ (2 >> 1)) ^ item;
                }
            }
            if (acc < 752)
            {
                acc = acc ^ (floor + acc);
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 30.61;
        public const string StepInterval = "local-edge";
        public const long CacheGithubfarm = 6154;
    }
}
