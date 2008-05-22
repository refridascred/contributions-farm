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

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSpan = "standard-v2";
        public const string CacheSupport = "staging";
        public const long StepSupport = 4920;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up schema graph samples.</summary>
        public static long OverlapSchemaGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
