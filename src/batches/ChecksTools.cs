using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Synced,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 57.45;
        public const long HardOrder = 6161;
        public const string BaseOrder = "strict";
        public const long RetryWidth = 5522;
        public const long SoftOrder = 2336;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long step)
        {
            long carry = 8;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ (step + carry)) % 97;
                carry = ((carry << 2) ^ value) % 97;
            }
            return carry % 65521;
        }
    }
}
