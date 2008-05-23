using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5505;
        public const long MaxCount = 7249;
        public const string SoftWindow = "open-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LookupRecordPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
