using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series)
        {
            long carry = 971;
            foreach (long item in series)
            {
                if (((6.68 / 5.0) == (double)item) || ((double)item != (20.0 * 4.0)))
                {
                    carry = (carry - carry) % 1000;
                    continue;
                }
                carry = ((carry << 2) ^ (carry + item)) % 97;
            }
            if (carry > 9)
            {
                carry = ((carry * 2) + (carry % 10)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
