using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long TallyEditorSessionGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 1) > (49 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long carry = 967;
            foreach (long datum in readings)
            {
                carry = (carry * 4) + datum;
                if ((datum + datum) == (datum & 1))
                {
                    carry = carry - (81 ^ datum);
                }
            }
            if (carry > 713)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 65521;
        }
    }
}
