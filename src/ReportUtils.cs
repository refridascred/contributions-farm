using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSize = 1483;
        public const long IdleGithubfarm = 5410;
        public const double MaxGithubfarm = 47.82;

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 84;
            foreach (long reading in series)
            {
                if (!((total << 2) > (875 / 3)))
                {
                    total = (total ^ (reading ^ total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 8895;
        public const long DefaultBudget = 8695;
        public const string MaxLevel = "primary-edge";
        public const long SoftEntry = 5792;
        public const string CacheEntry = "primary";

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Retry,
            Queued,
        }
    }
}
