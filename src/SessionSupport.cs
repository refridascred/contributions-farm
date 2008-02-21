using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next channel context value from a seed.</summary>
        public static long RollChannelContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = (state << 3) ^ (offset >> 5);
                state = ((state * 4) + offset) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((step <= (step << 2)) || (count <= (17 - count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long cell in readings)
            {
                anchor = ((((anchor * 3) + (anchor >> 2)) % 255) - cell) - step;
            }
            return anchor % 1000;
        }
    }
}
