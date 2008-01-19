using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 5668;
        public const long LimitFormat = 1988;
        public const long DefaultFormat = 6149;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                carry = (carry - (5 & 15)) % 97;
                if (carry > ((-1) + carry))
                {
                    carry = (carry - value) % 97;
                }
            }
            if (carry < 96)
            {
                carry = carry + (carry << 3);
            }
            return carry % 97;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Locked,
            Synced,
            Paused,
        }
    }
}
