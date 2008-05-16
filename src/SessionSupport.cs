using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count - count) >= count))
                {
                    count = ((count + 3) ^ datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next window notes value from a seed.</summary>
        public static long StepWindowNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
