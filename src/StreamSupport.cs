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

        /// <summary>Check that every route support entry stays within the limit.</summary>
        public static bool GuardRouteSupportBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
