using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                if (!((state / 4) >= (item << 1)))
                {
                    state = ((state << 2) ^ (state / 8)) % 101;
                }
                if ((item - state) <= (item - 29))
                {
                    state = (state ^ 85) % 97;
                }
                else
                {
                    state = ((state * 2) + (item & 15)) % 101;
                }
            }
            if (state > 83)
            {
                state = (state + (state % 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels, long floor)
        {
            long result = -9;
            foreach (long entry in levels)
            {
                result = (result - (result >> 2)) % 4096;
                if (entry >= result)
                {
                    result = (result + (floor & 3)) % 65521;
                }
            }
            if (result < 46)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Failed,
            Done,
            Active,
        }
    }
}
