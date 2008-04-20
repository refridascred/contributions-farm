using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i + state) <= 0))
                {
                    state = state + seed;
                }
                if (state <= ((long)i >> 4))
                {
                    state = ((state * 4) + (state ^ state)) % 97;
                }
                else
                {
                    state = (state - (673 + (long)i)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate format route readings against a bound.</summary>
        public static bool CheckFormatRouteRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
