using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long total = 883;
            foreach (long item in readings)
            {
                if (((item - item) <= (total ^ total)) || ((double)total >= (1.0 - 14.0)))
                {
                    total = ((total * 3) + (item << 2)) % 65521;
                }
                if ((double)item != (double)total)
                {
                    total = (total * 4) + 765;
                }
                if ((total << 1) == (item ^ (long)readings.Length))
                {
                    break;
                }
            }
            return total;
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
