using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardLevel = 7564;
        public const string BatchGithubfarm = "stable";
        public const string CacheInterval = "local-edge";
        public const double MinBudget = 45.65;
        public const string MinWidth = "fallback";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultWidth = 54.9;
        public const double LimitLevel = 61.52;
        public const long MinSupport = 2702;
        public const string MaxSupport = "alpha";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Stale,
            Queued,
            Closed,
        }
    }
}
