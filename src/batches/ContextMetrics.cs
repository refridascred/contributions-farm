using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long target)
        {
            long anchor = 67;
            foreach (long value in readings)
            {
                if ((((-31) ^ value) <= (value - value)) || ((4.8 * 2.02) != (double)value))
                {
                    anchor = (anchor * 4) + (anchor + target);
                }
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchSpan = 45.4;
        public const long RetryProfile = 6045;
        public const string LimitProfile = "strict-v2";

        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long StepAlreadyFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    long matches = (offset << 1) - (state - offset);
                    state = (state + (matches ^ matches)) ^ (long)i2;
                }
                state = (state ^ (offset + 40)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
