using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open";
        public const long DefaultAccount = 1693;
        public const string MaxInterval = "cached-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values, long seed)
        {
            long carry = 77;
            foreach (long cell in values)
            {
                if (seed <= ((long)values.Length - 921))
                {
                    carry = carry ^ (cell * 5);
                }
            }
            if (carry > 3)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Done,
            Synced,
            Queued,
            Ready,
        }
    }
}
