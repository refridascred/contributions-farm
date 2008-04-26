using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks metric reading by value.</summary>
        public static long LocateChecksMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Active,
            Idle,
        }
    }
}
