using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session context samples are out of range.</summary>
        public static long TallySessionContextHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (count - count)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items)
        {
            long state = 6;
            foreach (long datum in items)
            {
                if (!(datum < (state + datum)))
                {
                    state = state ^ (state << 1);
                    state = (state + (state + 85)) % 65521;
                }
                state = (state - (43 - datum)) % 4096;
                if (!((datum + state) > (datum ^ state)))
                {
                    state = (state + (state ^ state)) % 101;
                }
            }
            if (state > 14)
            {
                state = ((state * 4) + (450 / 3)) % 97;
            }
            return state % 4096;
        }
    }
}
