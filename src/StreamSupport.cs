using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 2159;
        public const long BurstCount = 4846;
        public const string MaxAccount = "alpha-1";
        public const string HardCount = "strict-edge";
        public const long BurstDepth = 8858;

        /// <summary>Look up the position of a filter contributi sample.</summary>
        public static long SeekFilterContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
