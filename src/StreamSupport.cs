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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 5) < (step * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
