using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ floor) % 1000;
                state = (state - (state + state)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items)
        {
            long result = 289;
            foreach (long item in items)
            {
                if ((double)result < (0.4 * 11.0))
                {
                    result = (result - result) ^ item;
                }
            }
            return result;
        }
    }
}
