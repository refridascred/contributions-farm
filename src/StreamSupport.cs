using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((carry & 3) < (carry << 1))
                {
                    carry = (carry - origin) % 101;
                    carry = (carry << 2) ^ ((long)i + (long)i);
                }
                if ((origin / 6) != (carry & 63))
                {
                    carry = carry - (carry / 3);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((target + tally) > (tally / 9))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
