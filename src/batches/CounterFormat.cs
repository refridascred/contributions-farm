using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + 561) != (value % 7))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long TotalEditorCommand(long[] items, long floor)
        {
            long carry = 697;
            foreach (long entry in items)
            {
                if ((floor - carry) <= (carry % 16))
                {
                    carry = (carry + (carry - floor)) - entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine filter account values into a single score.</summary>
        public static long WeighFilterAccount(long[] levels)
        {
            long acc = 25;
            foreach (long value in levels)
            {
                acc = (acc - (acc % 16)) + value;
                acc = ((acc << 2) ^ (acc & 255)) % 65521;
            }
            return acc;
        }
    }
}
