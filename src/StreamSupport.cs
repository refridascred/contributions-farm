using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                long span = state - (state - state);
                if (!((double)span > (3.0 * 8.4)))
                {
                    span = span + span;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (6 > (sample & 255))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long result = 869;
            foreach (long cell in series)
            {
                if (815 >= cell)
                {
                    result = (result ^ (cell + floor)) % 97;
                }
                else
                {
                    result = (result - (floor * 5)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
