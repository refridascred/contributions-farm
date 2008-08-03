using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate command batch samples.</summary>
        public static long TallyCommandBatch(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                carry = (carry + (cell - 22)) % 65521;
            }
            if (carry < 4)
            {
                carry = (carry - (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleBudget = 7794;
        public const long HardQueue = 6117;
        public const long LimitQueue = 4415;
    }
}
