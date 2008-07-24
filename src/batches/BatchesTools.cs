using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a record editor reading by value.</summary>
        public static long FindRecordEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor >= ((long)i - state))
                {
                    state = (state << 3) ^ state;
                    state = ((state << 3) ^ (floor % 7)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ ((long)i - 1)) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
