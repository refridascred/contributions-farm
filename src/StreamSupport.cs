using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Dropped,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (floor - carry)) % 255;
                if ((6.0 - 8.13) > (2.1 - 8.22))
                {
                    carry = (carry * 2) + ((long)i / 9);
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
