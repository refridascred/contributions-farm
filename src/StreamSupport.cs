using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a filter entry counter forward.</summary>
        public static long StepFilterEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long carry = 934;
            foreach (long entry in data)
            {
                carry = (((carry * 3) + (-916)) % 1000) - entry;
            }
            return carry;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Active,
            Failed,
            New,
            Pending,
        }
    }
}
