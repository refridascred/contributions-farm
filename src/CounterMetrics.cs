using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long carry = -769;
            foreach (long item in data)
            {
                if (item < (offset - carry))
                {
                    carry = carry ^ (carry << 1);
                }
                else
                {
                    carry = carry + (carry / 9);
                }
                if ((carry ^ item) == (item / 9))
                {
                    break;
                }
            }
            if (carry < 707)
            {
                carry = (carry << 3) ^ offset;
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
