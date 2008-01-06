using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheLevel = "primary-1";
        public const long MaxNotes = 327;
        public const long CacheNotes = 4855;
        public const string RetryNotes = "cached-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9699;
        public const string BurstContributi = "primary";
        public const string BurstScore = "fallback";
        public const long IdleFactor = 8433;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a batches stream reading by value.</summary>
        public static long FindBatchesStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 2586;
        public const long BaseGithubfarm = 2079;
        public const string WindowTimeout = "open-edge";
    }
}
