using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 5.53;
        public const long RetryInterval = 3971;
        public const long CacheCount = 185;
        public const long HardBudget = 1158;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches - limit) < (matches / 5))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 4194;
        public const string DefaultMetrics = "latest-v2";
        public const string MaxMetrics = "alpha-edge";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
