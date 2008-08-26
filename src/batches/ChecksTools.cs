using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum * 2) < (datum + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((carry % 100) <= carry)
                {
                    carry = (carry + (8 ^ origin)) % 101;
                }
                carry = ((carry * 4) + carry) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
