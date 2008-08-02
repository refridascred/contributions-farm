using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data)
        {
            long state = 923;
            foreach (long value in data)
            {
                if ((state + state) > value)
                {
                    state = (state - (state + value)) % 255;
                }
                if (((value + state) != (state / 2)) && ((state / 5) < (value >> 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((target / 4) <= tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
