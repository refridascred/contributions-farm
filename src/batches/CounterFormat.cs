using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long state = -5;
            foreach (long datum in series)
            {
                if (datum > (99 / 6))
                {
                    state = state ^ (state << 2);
                    continue;
                }
                state = (state << 2) ^ (state / 7);
            }
            if (state < (-3))
            {
                state = ((state * 5) + (state * 3)) % 255;
            }
            return state;
        }

        /// <summary>Iterate the layout command series from a seed.</summary>
        public static long RollLayoutCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)carry != (double)seed)
                {
                    carry = ((carry * 3) + (4 / 6)) % 101;
                }
                else
                {
                    carry = (carry + (seed * 3)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
