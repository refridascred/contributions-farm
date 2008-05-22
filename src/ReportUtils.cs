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

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long result = 69;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result << 2) ^ (2 / 2)) % 97) + (long)i;
                }
                result = ((result << 3) ^ (entry ^ entry)) % 4096;
                if (!((result + entry) <= result))
                {
                    result = (result - (5 % 24)) % 255;
                }
                if ((16.0 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return result % 65521;
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
