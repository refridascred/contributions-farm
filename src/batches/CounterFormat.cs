using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (floor + 9)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
