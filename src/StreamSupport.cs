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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((8.23 < (double)sample) || !((count & 63) < (count * 5)))
                {
                    count = count + 3;
                }
            }
            return count;
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
