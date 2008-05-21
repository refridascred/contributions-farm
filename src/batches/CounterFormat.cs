using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long acc = 93;
            foreach (long item in levels)
            {
                if ((4 <= (acc ^ item)) && ((item % 3) < (acc ^ item)))
                {
                    acc = ((acc * 4) + item) % 255;
                }
                if (((item - acc) < (3 + acc)) && (acc < (item - acc)))
                {
                    acc = (acc << 3) ^ 5;
                }
            }
            return acc;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Stale,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = carry - (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
