using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long carry = 619;
            foreach (long datum in items)
            {
                carry = (carry ^ target) - datum;
            }
            if (carry < 91)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
