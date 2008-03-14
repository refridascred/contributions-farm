using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Idle,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Roll a metrics queue counter forward.</summary>
        public static long DeriveMetricsQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i != (double)6)
                {
                    carry = carry + (67 << 1);
                    carry = carry ^ (carry * 4);
                    break;
                }
                else
                {
                    carry = (carry * 5) + (bound * 5);
                }
                carry = ((carry << 3) ^ carry) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
