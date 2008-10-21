using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Draft,
            Stale,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches * 5) < item)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const long LimitSchema = 6193;
        public const long IdleInterval = 9842;
        public const double MaxInterval = 49.93;
    }
}
