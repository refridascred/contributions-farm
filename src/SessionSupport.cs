using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((32 + carry) == ((long)i * 5))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ 212) % 97;
                }
                if (((8 + carry) <= carry) && ((carry - bound) > carry))
                {
                    carry = ((carry * 3) + (carry + bound)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ (long)i;
                }
                carry = (carry << 3) ^ (bound << 1);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
