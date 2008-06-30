using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next githubfarm layout value from a seed.</summary>
        public static long DeriveGithubfarmLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((4.95 / 2.0) >= (double)acc) && ((double)seed < (2.0 / 8.0)))
                {
                    acc = acc ^ 1;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Stale,
            Closed,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 35.89;
        public const long BaseTimeout = 6882;
        public const long SoftSize = 4033;
    }
}
