using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long carry = 35;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (4 + carry)) % 101) - entry;
            }
            return carry % 1000;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Pending,
            New,
            Active,
            Retry,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
