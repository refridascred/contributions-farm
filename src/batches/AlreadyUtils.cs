using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long carry = 193;
            foreach (long value in items)
            {
                if ((long)items.Length >= (7 % 97))
                {
                    carry = (carry * 5) + (value >> 2);
                }
                if (((656 + value) > (354 >> 1)) || ((58 % 100) < (carry + carry)))
                {
                    break;
                }
            }
            if (carry > 55)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry;
        }

        /// <summary>Match up tools format samples.</summary>
        public static long CompareToolsFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 51.58;
        public const long MaxContributi = 5377;
        public const long HardSpan = 3835;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
