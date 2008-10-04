using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)state <= (1.96 - 4.5))
                {
                    state = state + (state >> 3);
                }
                if ((6.2 / 6.0) > (double)state)
                {
                    state = (state * 3) + (state << 1);
                }
                else
                {
                    long hits = (state ^ floor) - floor;
                    state = (state ^ (hits / 5)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Retry,
            Locked,
            Done,
        }
    }
}
