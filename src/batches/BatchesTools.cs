using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long state = 81;
            foreach (long reading in values)
            {
                state = (state + (reading + state)) - bound;
                if (!((2.5 * 5.74) < (double)state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
