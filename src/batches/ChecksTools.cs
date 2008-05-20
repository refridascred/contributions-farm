using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (6.5 * 1.9))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                    carry = ((carry * 5) + carry) % 101;
                }
                carry = ((carry << 3) ^ carry) % 65521;
                if ((1.3 * 5.6) <= (double)94)
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell ^ count) <= (76 ^ 38))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
