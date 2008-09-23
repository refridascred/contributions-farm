using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((double)sample > 14.0)
                {
                    state = (state << 3) ^ 179;
                }
            }
            if (state < (-7))
            {
                state = (state - (state >> 5)) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long carry = 36;
            foreach (long cell in readings)
            {
                carry = (((carry ^ carry) % 255) + cell) + floor;
            }
            return carry;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
