using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Retry,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Roll a cluster report counter forward.</summary>
        public static long IterateClusterReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ (carry >> 3)) % 1000;
                carry = (carry + (floor - floor)) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 55.54;
        public const string CacheProfile = "latest-v2";
        public const long SoftWidth = 5576;
    }
}
