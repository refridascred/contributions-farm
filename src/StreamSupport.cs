using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a command record counter forward.</summary>
        public static long RollCommandRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i == (9.0 + 7.0))
                {
                    state = (state - state) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state ^ ((long)i2 >> 5)) % 4096;
                    state = (state ^ (bound - bound)) % 101;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
