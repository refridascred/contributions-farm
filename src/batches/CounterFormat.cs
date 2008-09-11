using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] items)
        {
            long carry = 4;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ entry) % 1000) + (long)i;
                }
                if (((carry * 5) < (carry + entry)) && (9 >= entry))
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry < 728)
            {
                carry = ((carry << 3) ^ (80 & 3)) % 255;
            }
            return carry;
        }
    }
}
